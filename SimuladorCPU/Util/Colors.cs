using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Util {
    /// <summary>
    /// Estructura para almacenar los colores que utiliza la aplicación
    /// </summary>
    public struct Colors {

        public static Color DashboardColor => Color.DodgerBlue;
        public static Color MenuButtonColor => DashboardColor;
        public static Color MenuButtonForeColor => Color.WhiteSmoke;
        public static Color MenuButtonOverColor => ColorTranslator.FromHtml("#4169E1");
        public static Color MenuButtonOverForeColor => Color.Black;
        public static Color ControlButtonForeColor => ColorTranslator.FromHtml("#7376BD");
        public static Color ControlButtonOverColor => ColorTranslator.FromHtml("#B0E0E6");
        public static Color CaptionColor => ColorTranslator.FromHtml("#7B68EE");
        public static Color ErrorMessageColor => ColorTranslator.FromHtml("#DC143C");
    }
}
