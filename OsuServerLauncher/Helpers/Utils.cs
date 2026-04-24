using Microsoft.Win32;
using OsuServerLauncher.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OsuServerLauncher.Helpers {
    public static class Utils {
        private static readonly string cacheDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cache");

        static Utils() {
            Directory.CreateDirectory(cacheDir);
        }
        public static Image GetServerIcon(string domain) {
            HttpClient client = new HttpClient();

            string GetCachePath(string key)
    {
                using (SHA256 sha = SHA256.Create()) {
                    byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(key));
                    string fileName = BitConverter.ToString(hash).Replace("-", "") + ".imgcache"; 
                    return Path.Combine(cacheDir, fileName);
                }
            }

            Image LoadFromCache(string path)
            {
                try {
                    if (!File.Exists(path)) return null;
                    return Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
                }
                catch { return null; }
            }

            void SaveToCache(string path, byte[] data) 
            {
                try {
                    File.WriteAllBytes(path, data);
                }
                catch { }
            }

            if (domain == "ppy.sh") {
                string url = "https://raw.githubusercontent.com/MinisBett/osu-server-launcher/master/osu_1024.png";
                string cachePath = GetCachePath(url);

                Image cached = LoadFromCache(cachePath);
                if (cached != null) return cached; 

                try {
                    byte[] data = client.GetByteArrayAsync(url).Result;
                    SaveToCache(cachePath, data);
                    return Image.FromStream(new MemoryStream(data));
                }
                catch { }
            }

            string[] urls = new string[]
            {
        $"https://osu.{domain}/osl/favicon.ico",
        $"https://osu.{domain}/static/osl/favicon.ico",
        $"https://osu.{domain}/favicon.ico",
        $"https://osu.{domain}/static/favicon.ico",
        $"https://osu.{domain}/static/favicon/favicon.ico",
        $"https://{domain}/osl/favicon.ico",
        $"https://{domain}/static/osl/favicon.ico",
        $"https://{domain}/favicon.ico",
        $"https://{domain}/static/favicon.ico",
        $"https://{domain}/static/favicon/favicon.ico"
            };

            foreach (string url in urls) {
                string cachePath = GetCachePath(url);
                try {
                    Image cached = LoadFromCache(cachePath);
                    if (cached != null) return cached;
                    byte[] data = client.GetByteArrayAsync(url).Result;
                    Image img = Image.FromStream(new MemoryStream(data));

                    if (img.Width != img.Height)
                        continue;
                    SaveToCache(cachePath, data);
                    if (img.Width < 64) {
                        Image img2 = new Bitmap(64, 64);
                        using (Graphics g = Graphics.FromImage(img2))
                            g.DrawImage(img, 64 / 2 - img.Width / 2, 64 / 2 - img.Height / 2);
                        img.Dispose();
                        return img2;
                    }

                    return img;
                }
                catch { }
            }

            return null;
        }

        public static string GetOsuPath(Data data) {
            if (data.AlternativeOsuPath != "" && File.Exists(Path.Combine(data.AlternativeOsuPath, "osu!.exe")))
                return data.AlternativeOsuPath;

            if (File.Exists(Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu!", "osu!.exe")))
                return Path.Combine(Environment.GetEnvironmentVariable("localappdata"), "osu!");

            try {
                // "F:\\osu!\\osu.exe",1
                string osuexe = Registry.GetValue("HKEY_CLASSES_ROOT\\osu\\DefaultIcon", "", "").ToString();
                osuexe = osuexe.Substring(1, osuexe.Length - 4);

                string osudir = new FileInfo(osuexe).DirectoryName;

                // exclude possible custom clients (folder or exe not named "osu!")
                if (new DirectoryInfo(osudir).Name != "osu!" || !File.Exists(Path.Combine(osudir, "osu!.exe")))
                    return "";

                return osudir;
            }
            catch { }

            return "";
        }
    }
}
