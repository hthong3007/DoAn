using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LTWD
{
    public partial class Form9 : Form
    {
        int second = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void tmStopwath_Tick(object sender, EventArgs e)
        {
            second++;
            lblDisplay.Text = second.ToString();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }
    }
}
