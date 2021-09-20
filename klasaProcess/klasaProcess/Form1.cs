using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace klasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void ButtonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.exe");
        }

        private void ButtonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            // početna web adresa

            startInfo.Arguments = "www.sser.hr";

            // pokretanje Internet Explorer-a

            Process.Start(startInfo);
        }
    }
}
