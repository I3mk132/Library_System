using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class clsAppSettings
    {
        
        public static class Colors
        {
            // Graph fill, selected icons, buttons, highlights
            public static string MainColor = "#e53935";

            // Background panels subtle section separation.
            public static string BackgroundColor = "#f3e5e5";

            // Card and Panel background for clean contrast
            public static string CardBackgroundColor = "#FFFFFF";

            // For bold titles and strong emphasis text.
            public static string HeaderTextColor = "#444444";

            // Descriptions, labels and secondary text.
            public static string SecondaryTextColor = "#999999";

            // Positive Change
            public static string PositiveChangeColor = "#00C853";

            // Negative Change
            public static string NegativeChangeColor = "#D50000";
        }
        static clsAppSettings()
        {
            _Font.AddFontFile("Fonts/Poppins-Medium.ttf"); // Make sure the filename matches
            _Font.AddFontFile("Fonts/Poppins-Regular.ttf");
            _Font.AddFontFile("Fonts/Poppins-SemiBold.ttf");
        }
        private static PrivateFontCollection _Font = new PrivateFontCollection();
        public static Font GetFont(short thickness, short size)
        {
            return new Font(_Font.Families[thickness], size);
        }



        public static void ApplyStyle(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            // Header height
            dgv.ColumnHeadersHeight = 26;

            // Row height
            dgv.RowTemplate.Height = 22;

            // Fonts (assuming your GetFont method is accessible statically)
            dgv.ColumnHeadersDefaultCellStyle.Font = GetFont(2, 14);
            dgv.DefaultCellStyle.Font = GetFont(1, 12);

            // Colors
            dgv.BackgroundColor = Color.FromArgb(238, 238, 238);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 238);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 57, 53);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Border and appearance
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
        }
    }
}
