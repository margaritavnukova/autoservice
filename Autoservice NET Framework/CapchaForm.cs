using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Autoservice_DLL;

namespace Autoservice_NET_Framework
{
    public partial class CapchaForm : Form
    {
        public CapchaForm()
        {
            InitializeComponent();
        }

        private void CapchaForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Capcha.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (Capcha.text == textBox1.Text)
                {
                    Close();
                }
                else 
                { 
                    MessageBox.Show("Ошибка"); 
                    pictureBox1.Image = Capcha.CreateImage(pictureBox1.Width, pictureBox1.Height); 
                }

                }
            else MessageBox.Show("Введите капчу");
        }
    }
}
