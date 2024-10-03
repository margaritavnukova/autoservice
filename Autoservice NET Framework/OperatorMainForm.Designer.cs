namespace Autoservice_NET_Framework
{
    partial class OperatorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.problemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.endMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.assistanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.partsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заявки";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 464);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 108);
            this.button4.TabIndex = 5;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 350);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 108);
            this.button3.TabIndex = 4;
            this.button3.Text = "Посмотреть отчет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 108);
            this.button2.TabIndex = 3;
            this.button2.Text = "Заявки в ожидании обработки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заявки в ожидании регистрации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Всего записей: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(850, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 82);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьПоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.CheckOnClick = true;
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idMenu,
            this.startMenu,
            this.modelMenu,
            this.problemMenu,
            this.statusMenu,
            this.endMenu,
            this.assistanceMenu,
            this.partsMenu,
            this.masterMenu,
            this.clientMenu});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // idMenu
            // 
            this.idMenu.Checked = true;
            this.idMenu.CheckOnClick = true;
            this.idMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idMenu.Name = "idMenu";
            this.idMenu.Size = new System.Drawing.Size(220, 22);
            this.idMenu.Text = "Идентификатору";
            this.idMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // startMenu
            // 
            this.startMenu.CheckOnClick = true;
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(220, 22);
            this.startMenu.Text = "Дате начала работы";
            this.startMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // modelMenu
            // 
            this.modelMenu.CheckOnClick = true;
            this.modelMenu.Name = "modelMenu";
            this.modelMenu.Size = new System.Drawing.Size(220, 22);
            this.modelMenu.Text = "Марке автомобиля";
            this.modelMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // problemMenu
            // 
            this.problemMenu.CheckOnClick = true;
            this.problemMenu.Name = "problemMenu";
            this.problemMenu.Size = new System.Drawing.Size(220, 22);
            this.problemMenu.Text = "Описанию проблемы";
            this.problemMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // statusMenu
            // 
            this.statusMenu.CheckOnClick = true;
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.Size = new System.Drawing.Size(220, 22);
            this.statusMenu.Text = "Статусу";
            this.statusMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // endMenu
            // 
            this.endMenu.Name = "endMenu";
            this.endMenu.Size = new System.Drawing.Size(220, 22);
            this.endMenu.Text = "Дате окончания работы";
            this.endMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // assistanceMenu
            // 
            this.assistanceMenu.CheckOnClick = true;
            this.assistanceMenu.Name = "assistanceMenu";
            this.assistanceMenu.Size = new System.Drawing.Size(220, 22);
            this.assistanceMenu.Text = "Оказанной помощи";
            this.assistanceMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // partsMenu
            // 
            this.partsMenu.CheckOnClick = true;
            this.partsMenu.Name = "partsMenu";
            this.partsMenu.Size = new System.Drawing.Size(220, 22);
            this.partsMenu.Text = "Использованным деталям";
            this.partsMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // masterMenu
            // 
            this.masterMenu.CheckOnClick = true;
            this.masterMenu.Name = "masterMenu";
            this.masterMenu.Size = new System.Drawing.Size(220, 22);
            this.masterMenu.Text = "Автомеханику";
            this.masterMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // clientMenu
            // 
            this.clientMenu.CheckOnClick = true;
            this.clientMenu.Name = "clientMenu";
            this.clientMenu.Size = new System.Drawing.Size(220, 22);
            this.clientMenu.Text = "Клиенту";
            this.clientMenu.CheckedChanged += new System.EventHandler(this.Menu_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.FilterAndSortEnabled = true;
            this.dataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.MaxFilterButtonImageHeight = 23;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(764, 446);
            this.dataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataGridView1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Поиск";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(60, 91);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OperatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 652);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OperatorMainForm";
            this.Text = "Главная форма оператора";
            this.Load += new System.EventHandler(this.OperatorMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idMenu;
        private System.Windows.Forms.ToolStripMenuItem startMenu;
        private System.Windows.Forms.ToolStripMenuItem modelMenu;
        private System.Windows.Forms.ToolStripMenuItem problemMenu;
        private System.Windows.Forms.ToolStripMenuItem statusMenu;
        private System.Windows.Forms.ToolStripMenuItem assistanceMenu;
        private System.Windows.Forms.ToolStripMenuItem partsMenu;
        private System.Windows.Forms.ToolStripMenuItem masterMenu;
        private System.Windows.Forms.ToolStripMenuItem endMenu;
        private System.Windows.Forms.ToolStripMenuItem clientMenu;
        private Zuby.ADGV.AdvancedDataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button5;
    }
}