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
    public partial class ProcessingRequestForm : Form
    {
        public ProcessingRequestForm()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();
        string id = string.Empty;

        private void ProcessingRequestForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT TOP (1) r. requestID, r.startDate, c.name, c.phone, r.problemDescryption FROM Request as r " +
                "LEFT JOIN Client as c ON r.clientID = c.clientID " +
                "WHERE r.requestStatus = '4'";

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            bd.GetData(query, dataAdapter, bindingSource1, dataGridView1);

            id = bd.ReadFromBD("SELECT TOP (1) requestID FROM Request WHERE requestStatus = '4'");

            label1.Text = "Заявка номер " + id;
            GetMasters();

            comboBox1.SelectedIndex = 0;
        }

        private void GetMasters()
        {
            string query = "SELECT name FROM Master";
            string M = bd.ReadFromBD(query);

            string[] ms = M.Split(',');

            foreach (string m in ms)
            {
                comboBox1.Items.Add(m);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int p = (int)numericUpDown1.Value;
            int masterID = comboBox1.SelectedIndex + 1;
            string oldInfo = bd.ReadFromBD($"SELECT problemDescryption FROM Request WHERE requestID = '{id}'");
            string newInfo = oldInfo + " //Уточнено// " + richTextBox1.Text;

            string query = $"UPDATE Request SET priority = N'{p}', masterID = N'{masterID}', problemDescryption = N'{newInfo}', requestStatus = '2' WHERE requestID = '{id}'";
            bd.WriteToBD(query);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
