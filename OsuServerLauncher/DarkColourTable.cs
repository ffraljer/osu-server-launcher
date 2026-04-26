using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuServerLauncher {
    public class DarkColourTable : ProfessionalColorTable { // I was today years old
        public override Color MenuItemSelected => ColorTranslator.FromHtml("#313244");
        public override Color MenuItemBorder => ColorTranslator.FromHtml("#45475a");
        public override Color MenuBorder => ColorTranslator.FromHtml("#45475a");
        public override Color ToolStripDropDownBackground => ColorTranslator.FromHtml("#1e1e2e");
        public override Color ImageMarginGradientBegin => ColorTranslator.FromHtml("#1e1e2e");
        public override Color ImageMarginGradientMiddle => ColorTranslator.FromHtml("#1e1e2e");
        public override Color ImageMarginGradientEnd => ColorTranslator.FromHtml("#1e1e2e");
    }
}
