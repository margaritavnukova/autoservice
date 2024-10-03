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
    public partial class MasterMainForm : Form
    {
        public MasterMainForm()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BD bd = new BD();

        private void MasterMainForm_Load(object sender, EventArgs e)
        {
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
                "WHERE r.requestStatus = '2' OR r.requestStatus = '3'", dataAdapter, bindingSource1, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterRequest mr = new MasterRequest();
            mr.ShowDialog();
        }
    }
}
