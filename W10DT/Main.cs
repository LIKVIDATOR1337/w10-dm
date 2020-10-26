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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string folder = "Personalize";
        public static string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\" + folder;


        private void off_Click(object sender, EventArgs e)
        {
            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue("AppsUseLightTheme", 0x0000001);
            MessageBox.Show(
                "Done!",
                "W10 Dark Theme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void on_Click(object sender, EventArgs e)
        {

            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue("AppsUseLightTheme", 0x00000000);
            MessageBox.Show(
                "Done!",
                "W10 Dark Theme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            string status = sk1.GetValue("AppsUseLightTheme").ToString();
            if (status == "1")
            {
                st.Text = "Dark theme: Off";
            }
            else
            {
                st.Text = "Dark theme: On";
            }
        }
    }
}
