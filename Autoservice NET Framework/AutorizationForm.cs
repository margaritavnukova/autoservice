using System.Drawing;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        BD bd = new BD();
        Button b;
        private string text = String.Empty;
        int tries = 0;

        private void Autorization_Load(object sender, EventArgs e)
        {
            myLoad();
        }

        private void OperatorMasterButton_Click(object sender, EventArgs e)
        {
            myChangeGuiToEnterPassword();
            //запоминаю кнопку для обращения к нужной таблице из таблиц Мастер/Оператор
            b = sender as Button;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                PasswordText.UseSystemPasswordChar = false;
            else
                PasswordText.UseSystemPasswordChar = true;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            RequestForm rf = new RequestForm();
            rf.ShowDialog();
        }

        private void myCheckPassword()
        {
            string role = "";
            BD.login = LoginText.Text;
            string password = PasswordText.Text;

            if (b == OperatorButton)
                role = "Operator";
            else role = "Master";

            string query = $"SELECT Password FROM {role} WHERE Login = '{BD.login}'";
            string checkPassword = bd.ReadFromBD(query);
            checkPassword.Trim();

            if (string.IsNullOrEmpty(checkPassword))
                MessageBox.Show("Такого пользователя не существует");
            else
            {
                int success = -1;
                DateTime dateTime = DateTime.Now;

                if (password == checkPassword)
                {
                    success = 1;
                    MessageBox.Show("Успешная авторизация");
                    if (role == "Operator")
                    {
                        OperatorMainForm omf = new OperatorMainForm();
                        omf.ShowDialog();
                    }
                    else
                    {
                        MasterMainForm mmf = new MasterMainForm();
                        mmf.ShowDialog();
                    }
                }
                else
                {
                    success = 0;

                    MessageBox.Show("Пароль неверный");
                    tries++;
                    if (tries > 2)
                    {
                        CapchaForm cf = new CapchaForm();
                        cf.ShowDialog();
                    }
                }

                string q = $"INSERT INTO Logs VALUES ('{BD.login}', '{dateTime}', '{success}')";
                bd.WriteToBD(q);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            myLoad();

            groupBox.Text = "Необходима авторизация";

            CustomerButton.Enabled = CustomerButton.Visible = true;
            OperatorButton.Enabled = OperatorButton.Visible = true;
            MasterButton.Enabled = MasterButton.Visible = true;

            label1.Text = "Вы:";
            groupBox.BackColor = Color.Ivory;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            myCheckPassword();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            if (LoginText.Text.Length > 0 && PasswordText.Text.Length > 0) 
            { 
                OkButton.Enabled = true;
            }
        }

        private void myLoad()
        {
            LoginText.Enabled = LoginText.Visible = false;
            PasswordText.Enabled = PasswordText.Visible = false;
            label2.Enabled = label2.Visible = false;
            OkButton.Enabled = OkButton.Visible = false;
            BackButton.Enabled = BackButton.Visible = false;
            checkBox1.Enabled = checkBox1.Visible = false;
        }

        private void myChangeGuiToEnterPassword()
        {
            groupBox.Text = "Для входа введите логин и пароль";

            CustomerButton.Enabled = CustomerButton.Visible = false;
            OperatorButton.Enabled = OperatorButton.Visible = false;
            MasterButton.Enabled = MasterButton.Visible = false;

            groupBox.BackColor = Color.PeachPuff;
            LoginText.Enabled = LoginText.Visible = true;
            PasswordText.Enabled = PasswordText.Visible = true;
            label1.Text = "Логин:";
            label2.Enabled = label2.Visible = true;
            OkButton.Visible = true;
            BackButton.Enabled = BackButton.Visible = true;
            checkBox1.Enabled = checkBox1.Visible = true;
            PasswordText.UseSystemPasswordChar = true;
        }

        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "DELETE FROM Client WHERE Phone = '+7(000)000-00-00'";
            bd.DeleteFromBD(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogsReportForm lrm = new LogsReportForm();
            lrm.ShowDialog();
        }
    }
}
