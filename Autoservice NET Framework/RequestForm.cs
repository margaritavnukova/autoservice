using System;
using System.Collections;
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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        BD bd = new BD();

        private void RequestForm_Load(object sender, EventArgs e)
        {
            GetCarModels();
            ShowStatictics(); ShowPhones();

            SendButton.Enabled = false;
            EditButton.Enabled = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            string name = textBox2.Text;
            DateTime dt = DateTime.Now;
            string startDate = dt.Date.ToString("yyyy-MM-dd");
            string carModel = comboBox1.Text;
            string problemDescryption = richTextBox1.Text;

            //adding new client
            string queryC = $"INSERT INTO Client " +
                $"VALUES (N'{name}', '{phone}');" +
                $"SELECT clientID FROM Client WHERE phone = '{phone}'";
            string id = "";
            try { id = bd.ReadFromBD(queryC); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return; }

            //adding new request
            string queryR = $"INSERT INTO Request(startDate, carModel, problemDescryption, clientID, requestStatus) " +
                $"VALUES ('{startDate}', N'{carModel}', N'{problemDescryption}', '{id}', '1')";
            try{ bd.WriteToBD(queryR);}
            catch (Exception ex) 
            { MessageBox.Show(ex.Message); return; }
            finally { MessageBox.Show("Заявка отправлена"); Close(); }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 0 && textBox2.Text.Length < 0 && richTextBox1.Text.Length < 0)
                SendButton.Enabled = false;
            else SendButton.Enabled = true;

            if (textBox1.Text.Length < 0)
                EditButton.Enabled = false;
            else EditButton.Enabled = true;
        }

        private void GetCarModels()
        {
            string query = "SELECT modelID FROM CarModel";
            string strCars = bd.ReadFromBD(query);

            string[] cars = strCars.Split(',');

            foreach (string car in cars)
            {
                comboBox1.Items.Add(car);
            }
        }

        private void ShowStatictics()
        {
            double a = Calculations.AvTimeInDays(bd);
            AvTimeLabel.Text = $"Среднее время выполнения заявки: {a} дней.";

            double с = Calculations.AllRequests(bd);
            AllRequestsLabel.Text = $"Количество выполненных заявок: {с}.";
        }

        private void ShowPhones()
        {
            bd = new BD();

            string queryP = $"SELECT Phone FROM Operator WHERE Login = 'login1'";
            string phone = bd.ReadFromBD(queryP);

            string queryN = $"SELECT Name FROM Operator WHERE Login = 'login1'";
            string name = bd.ReadFromBD(queryN);

            string queryP2 = $"SELECT Phone FROM Operator WHERE Login = 'login4'";
            string phone2 = bd.ReadFromBD(queryP2);

            string queryN2 = $"SELECT Name FROM Operator WHERE Login = 'login4'";
            string name2 = bd.ReadFromBD(queryN2);

            PhoneLabel1.Text = phone + "Оператор " + name;
            PhoneLabel2.Text = phone2 + "Оператор " + name2;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            string query = $"SELECT TOP (1) c.name, r.carModel, r.problemDescryption FROM Request as r " +
                $"LEFT JOIN Client as c " +
                $"ON r.clientID = c.clientID " +
                $"WHERE c.phone = '{phone}' AND (requestStatus = '1' OR requestStatus = '4')";
            string info = bd.ReadFromBD(query);
            string[] infos = new string[0];

            if (info != "")
            {
                infos = info.Split(',');

                textBox2.Text = infos[0];
                comboBox1.Text = infos[1];
                richTextBox1.Text = infos[2];
            }
            else MessageBox.Show("Нет заявки с таким номером"); 
        }
    }
}
