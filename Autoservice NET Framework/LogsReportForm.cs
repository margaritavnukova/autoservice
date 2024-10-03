using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class LogsReportForm : Form
    {
        public LogsReportForm()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();

        private void LogsReportForm_Load(object sender, EventArgs e)
        {
            GetLogs("");

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            bd.GetData("SELECT logID as Номер, login as Логин, datetime as Дата, success as Успех FROM Logs", dataAdapter, bindingSource1, dataGridView1);
        }

        private void GetLogs(string l)
        {
            string query = "", query2 = "";
            if (string.IsNullOrEmpty(l))
            {
                query = "SELECT login FROM Master";
                query2 = "SELECT login FROM Operator";
            }
            else
            {
                query = $"SELECT login FROM Master WHERE login = '{l}'";
                query2 = $"SELECT login FROM Operator WHERE login = '{l}'";
            }

            string M = bd.ReadFromBD(query);

            string[] ms = M.Split(',');

            foreach (string m in ms)
            {
                comboBox1.Items.Add(m);
            }

            string O = bd.ReadFromBD(query2);

            string[] os = O.Split(',');

            foreach (string o in os)
            {
                comboBox1.Items.Add(o);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string l = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = bindingSource1;
            bd.GetData($"SELECT logID as Номер, login as Логин, datetime as Дата, success as Успех FROM Logs WHERE login = '{l}'", dataAdapter, bindingSource1, dataGridView1);
        }
    }
}
