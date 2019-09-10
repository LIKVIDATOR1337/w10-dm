using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W10DM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string rofl = "Personalize";
            string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\" + rofl;

            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue("AppsUseLightTheme", 0x0000001);
            MessageBox.Show(
                "Done!",
                "W10 Dark Mode",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize
            string rofl = "Personalize";
            string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\" + rofl;

            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue("AppsUseLightTheme", 0x00000000);
            MessageBox.Show(
                "Done!",
                "W10 Dark Mode",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
