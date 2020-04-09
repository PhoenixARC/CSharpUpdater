using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace updatertemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentversion = "1.8B";
            System.IO.File.Delete("Update.zip");
            try
            {
                var WebClient = new System.Net.WebClient();
                var client = new System.Net.WebClient();
                string updateversion1 = (WebClient.DownloadString("https://pastebin.com/raw/BXSD606q"));
                string updateversion = updateversion1.Split(';')[0];
                string changes = (WebClient.DownloadString("https://pastebin.com/raw/MdVrAdHn"));
                if (currentversion != updateversion)
                {
                    MessageBox.Show("Update Avaliable! \n Downloading now! \n" + changes);
                    client.DownloadFile("https://www.dropbox.com/s/map1szqoxa0af75/Release.zip?dl=1", "Update.zip");
                    System.Diagnostics.Process.Start("Updater.exe");
                }
                else
                {
                    MessageBox.Show("You are on the latest Avaliable Version!");
                }
            }
            catch
            {

            }
        }
    }
}
