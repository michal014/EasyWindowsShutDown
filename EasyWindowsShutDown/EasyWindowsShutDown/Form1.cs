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

namespace EasyWindowsShutDown
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            long time = Convert.ToInt64(textBoxHours.Text) * 3600 + Convert.ToInt64(textBoxMinutes.Text) * 60 + Convert.ToInt64(textBoxSecounds.Text);
            string command = "/C shutdown -s -t "+ time.ToString();
            Process cmd = new Process();
            System.Diagnostics.Process.Start("CMD.exe", command);
        }
    }
}
