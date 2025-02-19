﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Autoservice_NET_Framework
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneLabel2 = new System.Windows.Forms.Label();
            this.PhoneLabel1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AllRequestsLabel = new System.Windows.Forms.Label();
            this.AvTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.BackButton);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(125, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 693);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните анкету";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(33, 576);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(179, 93);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "Отредактировать другую заявку";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SandyBrown;
            this.BackButton.Location = new System.Drawing.Point(785, 576);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(179, 93);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(931, 39);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 96);
            this.textBox1.Mask = "+7(000)000-00-00";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(931, 38);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Опишите свою проблему:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите марку автомобиля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Телефон:";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.SandyBrown;
            this.SendButton.Location = new System.Drawing.Point(254, 576);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(489, 93);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 380);
            this.richTextBox1.MaxLength = 50;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(931, 173);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(931, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PhoneLabel2);
            this.panel1.Controls.Add(this.PhoneLabel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.AllRequestsLabel);
            this.panel1.Controls.Add(this.AvTimeLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(-6, 710);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 100);
            this.panel1.TabIndex = 1;
            // 
            // PhoneLabel2
            // 
            this.PhoneLabel2.AutoSize = true;
            this.PhoneLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.PhoneLabel2.Location = new System.Drawing.Point(630, 57);
            this.PhoneLabel2.Name = "PhoneLabel2";
            this.PhoneLabel2.Size = new System.Drawing.Size(45, 20);
            this.PhoneLabel2.TabIndex = 5;
            this.PhoneLabel2.Text = "label8";
            // 
            // PhoneLabel1
            // 
            this.PhoneLabel1.AutoSize = true;
            this.PhoneLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.PhoneLabel1.Location = new System.Drawing.Point(630, 37);
            this.PhoneLabel1.Name = "PhoneLabel1";
            this.PhoneLabel1.Size = new System.Drawing.Size(45, 20);
            this.PhoneLabel1.TabIndex = 4;
            this.PhoneLabel1.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(630, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Контактные данные:";
            // 
            // AllRequestsLabel
            // 
            this.AllRequestsLabel.AutoSize = true;
            this.AllRequestsLabel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.AllRequestsLabel.Location = new System.Drawing.Point(18, 57);
            this.AllRequestsLabel.Name = "AllRequestsLabel";
            this.AllRequestsLabel.Size = new System.Drawing.Size(45, 20);
            this.AllRequestsLabel.TabIndex = 2;
            this.AllRequestsLabel.Text = "label8";
            // 
            // AvTimeLabel
            // 
            this.AvTimeLabel.AutoSize = true;
            this.AvTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.AvTimeLabel.Location = new System.Drawing.Point(18, 37);
            this.AvTimeLabel.Name = "AvTimeLabel";
            this.AvTimeLabel.Size = new System.Drawing.Size(45, 20);
            this.AvTimeLabel.TabIndex = 1;
            this.AvTimeLabel.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Наша статистика:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 77);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1127, 592);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 111);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 810);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestForm";
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button SendButton;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label AllRequestsLabel;
        private Label AvTimeLabel;
        private Label label6;
        private Label label7;
        private Label PhoneLabel2;
        private Label PhoneLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaskedTextBox textBox1;
        private ComboBox comboBox1;
        private Button BackButton;
        private Button EditButton;
    }
}