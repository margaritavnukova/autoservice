using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class OperatorMainForm : Form
    {
        public OperatorMainForm()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();
        readonly string q =
            "SELECT r.requestID as Номер, r.startDate as Начало, " +
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
                "ON r.clientID = c.clientID ";

        private void OperatorMainForm_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            bd.GetData(q, dataAdapter, bindingSource1, dataGridView1);

            string query = $"SELECT TOP (1) name FROM Operator WHERE login = '{BD.login}'";
            string r = bd.ReadFromBD(query);
            label1.Text += $" \t Оператор: {r}";

            string query2 = "SELECT COUNT(*) FROM Request";
            string r2 = bd.ReadFromBD(query2);
            label2.Text = $"Всего заявок: {r2}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RegisterRequestForm rrf = new RegisterRequestForm();
            rrf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessingRequestForm prf = new ProcessingRequestForm();
            prf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bd.GetData(q, dataAdapter, bindingSource1, dataGridView1);

            string query2 = "SELECT COUNT(*) FROM Request";
            string r2 = bd.ReadFromBD(query2);

            int rows = dataGridView1.Rows.Count - 1;
            int rows2 = Convert.ToInt32(r2);

            if (rows == rows2)
                label2.Text = $"Всего заявок: {rows2}";
            else label2.Text = $"Выведено заявок: {rows} из {rows2}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string t = searchTextBox.Text;
            string query = $"{q} WHERE r.requestID LIKE N'%{t}%' " +
                $"OR r.carModel LIKE N'%{t}%' " +
                $"OR r.problemDescryption LIKE N'%{t}%' " +
                $"OR s.specification LIKE N'%{t}%' " +
                $"OR r.assistanceProvided LIKE N'%{t}%' " +
                $"OR r.repairParts LIKE N'%{t}%' " +
                $"OR m.name LIKE N'%{t}%' " +
                $"OR c.name LIKE N'%{t}%' ";
            bd.GetData(query, dataAdapter, bindingSource1, dataGridView1);

            string query2 = "SELECT COUNT(*) FROM Request";
            string r2 = bd.ReadFromBD(query2);

            int rows = dataGridView1.Rows.Count - 1;
            int rows2 = Convert.ToInt32(r2);

            if (rows == rows2)
                label2.Text = $"Всего заявок: {rows2}";
            else label2.Text = $"Выведено заявок: {rows} из {rows2}";
        }

        private void Menu_CheckedChanged(object sender, EventArgs e)
        {
            string query = $"{q} ORDER BY ";

            if (idMenu.Checked) 
            { query += " requestID,"; }
            if (startMenu.Checked) 
            { query += " startDate,"; }
            if (modelMenu.Checked) 
            { query += " carModel,"; }
            if (problemMenu.Checked) 
            { query += " problemDescryption,"; }
            if (statusMenu.Checked) 
            { query += " status,"; }
            if (endMenu.Checked) 
            { query += " completionDate,"; }
            if (assistanceMenu.Checked) 
            { query += " assistanceProvided,"; }
            if (partsMenu.Checked) 
            { query += " repairParts,"; }
            if (masterMenu.Checked) 
            { query += " master,"; }
            if (clientMenu.Checked) 
            { query += " client,"; }

            query = query.Trim(',');

            bd.GetData(query, dataAdapter, bindingSource1, dataGridView1);  
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length < 0)
                button5.Enabled = false;
            else button5.Enabled = true;
        }
    }
}
