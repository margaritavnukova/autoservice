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
    public partial class RegisterRequestForm : Form
    {
        public RegisterRequestForm()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();
        string id = string.Empty;

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterRequestForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT TOP (1) r. requestID, r.startDate, c.name, c.phone, r.problemDescryption FROM Request as r " +
                "LEFT JOIN Client as c ON r.clientID = c.clientID " +
                "WHERE r.requestStatus = '1'";

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            bd.GetData(query, dataAdapter, bindingSource1, dataGridView1);

            id = bd.ReadFromBD("SELECT TOP (1) requestID FROM Request WHERE requestStatus = '1'");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Request SET requestStatus = '4' WHERE requestID = '{id}'";
            try
            {
                bd.WriteToBD(query);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            MessageBox.Show("Статус заявки изменен на зарегистрированную.");
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Request WHERE requestID = '{id}'";
            try
            {
                bd.WriteToBD(query);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            MessageBox.Show("Заявка удалена.");
            Close();
        }
    }
}
