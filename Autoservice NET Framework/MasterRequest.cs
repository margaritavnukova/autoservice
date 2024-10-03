using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class MasterRequest : Form
    {
        public MasterRequest()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();
        string id = string.Empty;

        private void MasterRequest_Load(object sender, EventArgs e)
        {
            id = bd.ReadFromBD("SELECT TOP (1) requestID FROM Request WHERE requestStatus = '2'");
            label1.Text = "Заявка номер " + id;

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            bd.GetData("SELECT r.requestID as Номер, r.startDate as Начало, " +
                "r.carModel as Модель, r.problemDescryption as Проблема, " +
                "s.specification as Статус, r.completionDate as Завершение, " +
                "r.assistanceProvided as Помощь, r.repairParts as Детали, " +
                "m.name as Мастер, c.name as Клиент    " +
                "FROM Request as r " +
                "LEFT JOIN RequestStatus as s " +
                "ON r.requestStatus = s.statusID " +
                "LEFT JOIN Master as m " +
                "ON r.masterID = m.masterID " +
                "LEFT JOIN Client as c " +
                "ON r.clientID = c.clientID " +
                $"WHERE r.requestID = '{id}'", dataAdapter, bindingSource1, dataGridView1);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string repairs = "";
            string parts = "";
            if (richTextBox1.Text.Length > 0)
                repairs = richTextBox1.Text;
            if (richTextBox2.Text.Length > 0)
                parts = richTextBox2.Text;

            DateTime CDate = DateTime.Today;

            string query = $"UPDATE Request SET " +
                $"requestStatus = '3', " +
                $"completionDate = N'{CDate}', " +
                $"assistanceProvided = N'{repairs}', " +
                $"repairParts = N'{parts}' " +
                $"WHERE requestID = '{id}'";

            try { bd.WriteToBD(query); } 
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Close();
        }
    }
}
