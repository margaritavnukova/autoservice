using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Autoservice_NET_Framework
{
    partial class AutorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MasterButton = new System.Windows.Forms.Button();
            this.OperatorButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 501);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Ivory;
            this.groupBox.Controls.Add(this.BackButton);
            this.groupBox.Controls.Add(this.checkBox1);
            this.groupBox.Controls.Add(this.OkButton);
            this.groupBox.Controls.Add(this.PasswordText);
            this.groupBox.Controls.Add(this.LoginText);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.MasterButton);
            this.groupBox.Controls.Add(this.OperatorButton);
            this.groupBox.Controls.Add(this.CustomerButton);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(334, 110);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(495, 319);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Необходима авторизация";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackButton.Location = new System.Drawing.Point(366, 262);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 42);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(263, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 35);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.OkButton.Location = new System.Drawing.Point(140, 262);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(220, 42);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(27, 217);
            this.PasswordText.MaxLength = 6;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(220, 38);
            this.PasswordText.TabIndex = 6;
            this.PasswordText.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(27, 105);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(441, 38);
            this.LoginText.TabIndex = 5;
            this.LoginText.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // MasterButton
            // 
            this.MasterButton.BackColor = System.Drawing.Color.SandyBrown;
            this.MasterButton.Location = new System.Drawing.Point(27, 241);
            this.MasterButton.Name = "MasterButton";
            this.MasterButton.Size = new System.Drawing.Size(441, 63);
            this.MasterButton.TabIndex = 3;
            this.MasterButton.Text = "Механик";
            this.MasterButton.UseVisualStyleBackColor = false;
            this.MasterButton.Click += new System.EventHandler(this.OperatorMasterButton_Click);
            // 
            // OperatorButton
            // 
            this.OperatorButton.BackColor = System.Drawing.Color.SandyBrown;
            this.OperatorButton.Location = new System.Drawing.Point(27, 172);
            this.OperatorButton.Name = "OperatorButton";
            this.OperatorButton.Size = new System.Drawing.Size(441, 63);
            this.OperatorButton.TabIndex = 2;
            this.OperatorButton.Text = "Оператор";
            this.OperatorButton.UseVisualStyleBackColor = false;
            this.OperatorButton.Click += new System.EventHandler(this.OperatorMasterButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CustomerButton.Location = new System.Drawing.Point(27, 103);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(441, 63);
            this.CustomerButton.TabIndex = 1;
            this.CustomerButton.Text = "Заказчик";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(918, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Показать историю входов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 798);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AutorizationForm";
            this.Text = "Автосервис \"Новый поворот\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox;
        private Button MasterButton;
        private Button OperatorButton;
        private Button CustomerButton;
        private Label label1;
        private Button OkButton;
        private TextBox PasswordText;
        private TextBox LoginText;
        private Label label2;
        private CheckBox checkBox1;
        private Button BackButton;
        private Button button1;
    }
}
