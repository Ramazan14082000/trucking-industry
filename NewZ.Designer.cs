namespace Курс_3
{
    partial class NewZ
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIOVtb = new System.Windows.Forms.ComboBox();
            this.Orgtb = new System.Windows.Forms.TextBox();
            this.CLIENTtb = new System.Windows.Forms.ComboBox();
            this.DATEOTtb = new System.Windows.Forms.DateTimePicker();
            this.ADRtb = new System.Windows.Forms.TextBox();
            this.GRtb = new System.Windows.Forms.ComboBox();
            this.DATEVG = new System.Windows.Forms.DateTimePicker();
            this.NAMEGRtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.STtb = new System.Windows.Forms.TextBox();
            this.STOPL = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грузовикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1308, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FIOVtb
            // 
            this.FIOVtb.FormattingEnabled = true;
            this.FIOVtb.Location = new System.Drawing.Point(186, 77);
            this.FIOVtb.Name = "FIOVtb";
            this.FIOVtb.Size = new System.Drawing.Size(246, 21);
            this.FIOVtb.TabIndex = 1;
            this.FIOVtb.SelectedIndexChanged += new System.EventHandler(this.FIOVtb_SelectedIndexChanged);
            // 
            // Orgtb
            // 
            this.Orgtb.Location = new System.Drawing.Point(7, 78);
            this.Orgtb.Name = "Orgtb";
            this.Orgtb.Size = new System.Drawing.Size(178, 20);
            this.Orgtb.TabIndex = 2;
            // 
            // CLIENTtb
            // 
            this.CLIENTtb.DisplayMember = "Клиент";
            this.CLIENTtb.FormattingEnabled = true;
            this.CLIENTtb.Location = new System.Drawing.Point(7, 122);
            this.CLIENTtb.Name = "CLIENTtb";
            this.CLIENTtb.Size = new System.Drawing.Size(247, 21);
            this.CLIENTtb.TabIndex = 3;
            this.CLIENTtb.ValueMember = "Клиент";
            this.CLIENTtb.SelectedIndexChanged += new System.EventHandler(this.CLIENTtb_SelectedIndexChanged);
            // 
            // DATEOTtb
            // 
            this.DATEOTtb.Location = new System.Drawing.Point(255, 123);
            this.DATEOTtb.Name = "DATEOTtb";
            this.DATEOTtb.Size = new System.Drawing.Size(170, 20);
            this.DATEOTtb.TabIndex = 4;
            // 
            // ADRtb
            // 
            this.ADRtb.Location = new System.Drawing.Point(433, 77);
            this.ADRtb.Name = "ADRtb";
            this.ADRtb.Size = new System.Drawing.Size(321, 20);
            this.ADRtb.TabIndex = 5;
            // 
            // GRtb
            // 
            this.GRtb.DisplayMember = "Марка";
            this.GRtb.FormattingEnabled = true;
            this.GRtb.Location = new System.Drawing.Point(755, 76);
            this.GRtb.Name = "GRtb";
            this.GRtb.Size = new System.Drawing.Size(147, 21);
            this.GRtb.TabIndex = 6;
            this.GRtb.ValueMember = "Марка";
            this.GRtb.SelectedIndexChanged += new System.EventHandler(this.GRtb_SelectedIndexChanged);
            // 
            // DATEVG
            // 
            this.DATEVG.Location = new System.Drawing.Point(601, 123);
            this.DATEVG.Name = "DATEVG";
            this.DATEVG.Size = new System.Drawing.Size(153, 20);
            this.DATEVG.TabIndex = 7;
            // 
            // NAMEGRtb
            // 
            this.NAMEGRtb.Location = new System.Drawing.Point(426, 123);
            this.NAMEGRtb.Name = "NAMEGRtb";
            this.NAMEGRtb.Size = new System.Drawing.Size(174, 20);
            this.NAMEGRtb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ФИО водителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Грузовик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата выгрузки";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата отгрузки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Название груза";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(905, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Стоимость";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // STtb
            // 
            this.STtb.Location = new System.Drawing.Point(908, 77);
            this.STtb.Name = "STtb";
            this.STtb.Size = new System.Drawing.Size(136, 20);
            this.STtb.TabIndex = 20;
            // 
            // STOPL
            // 
            this.STOPL.FormattingEnabled = true;
            this.STOPL.Location = new System.Drawing.Point(755, 122);
            this.STOPL.Name = "STOPL";
            this.STOPL.Size = new System.Drawing.Size(136, 21);
            this.STOPL.TabIndex = 21;
            this.STOPL.SelectedIndexChanged += new System.EventHandler(this.STOPL_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(752, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Статус оплаты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 64);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.водителиToolStripMenuItem.Text = "Водители";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // грузовикиToolStripMenuItem
            // 
            this.грузовикиToolStripMenuItem.Name = "грузовикиToolStripMenuItem";
            this.грузовикиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.грузовикиToolStripMenuItem.Text = "Грузовики";
            this.грузовикиToolStripMenuItem.Click += new System.EventHandler(this.грузовикиToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.водителиToolStripMenuItem,
            this.грузовикиToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // NewZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.STOPL);
            this.Controls.Add(this.STtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAMEGRtb);
            this.Controls.Add(this.DATEVG);
            this.Controls.Add(this.GRtb);
            this.Controls.Add(this.ADRtb);
            this.Controls.Add(this.DATEOTtb);
            this.Controls.Add(this.CLIENTtb);
            this.Controls.Add(this.Orgtb);
            this.Controls.Add(this.FIOVtb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewZ";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox FIOVtb;
        private System.Windows.Forms.TextBox Orgtb;
        private System.Windows.Forms.ComboBox CLIENTtb;
        private System.Windows.Forms.DateTimePicker DATEOTtb;
        private System.Windows.Forms.TextBox ADRtb;
        private System.Windows.Forms.ComboBox GRtb;
        private System.Windows.Forms.DateTimePicker DATEVG;
        private System.Windows.Forms.TextBox NAMEGRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox STtb;
        private System.Windows.Forms.ComboBox STOPL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грузовикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

