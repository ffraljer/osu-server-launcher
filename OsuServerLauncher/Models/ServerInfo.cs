using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuServerLauncher.Models {
    public class ServerInfo {
        [JsonProperty("username")]
        public string Username { get; private set; }

        [JsonProperty("password")]
        public string Password { get; private set; }

        [JsonProperty("clientlocation")]
        public string? ClientLocation { get; private set; }

        public ServerInfo(string username, string password) {
            Username = username;
            Password = password;
            ClientLocation = null;
        }
        [JsonConstructor]
        public ServerInfo(string username, string password, string clientLocation) {
            Username = username;
            Password = password;
            ClientLocation = clientLocation;
        }
    }
}
