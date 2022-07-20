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
        private static bool planned = false;
        public FormMain()
        {
            InitializeComponent();
        }

        public void StartMethod()
        {
            numericUpDownHours.Value = 0;
            numericUpDownMinutes.Value = 0;
            numericUpDownSecounds.Value = 0;

            if (planned)
            {
                numericUpDownHours.Enabled = false;
                numericUpDownMinutes.Enabled = false;
                numericUpDownSecounds.Enabled = false;
                buttonShutDown.Enabled = false;
                buttonCancel.Enabled = true;
            }
            else
            {
                numericUpDownHours.Enabled = true;
                numericUpDownMinutes.Enabled = true;
                numericUpDownSecounds.Enabled = true;
                buttonShutDown.Enabled = true;
                buttonCancel.Enabled = false;
            }
        }

        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            planned = true;
            ulong time = Convert.ToUInt64(numericUpDownHours.Value) * 3600 + Convert.ToUInt64(numericUpDownMinutes.Value) * 60 + Convert.ToUInt64(numericUpDownSecounds.Value);
            string command = "/C shutdown -s -t "+ time.ToString();
            System.Diagnostics.Process.Start("CMD.exe", command);
            StartMethod();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            planned = false;
            string command = "/C shutdown -a ";
            System.Diagnostics.Process.Start("CMD.exe", command);
            StartMethod();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StartMethod();
        }
    }
}
