using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Ban_DienThoai
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            //list theme
            //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|
            //Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|
            //Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|
            //Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|
            //Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Metropolis";
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            Application.Run(new FormDangNhap());
        }
    }
}
