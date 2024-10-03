﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        BD bd = new BD();

        private void ReportForm_Load(object sender, EventArgs e)
        {
            label5.Text = Calculations.AllRequests(bd).ToString();
            label6.Text = Calculations.AvTimeInDays(bd).ToString() + " дней";
            label7.Text = Calculations.AllParts(bd).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
