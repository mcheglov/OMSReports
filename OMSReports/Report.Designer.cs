namespace OMSReports
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.adminCB = new System.Windows.Forms.ComboBox();
            this.registryBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.daysDGV = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.monthtestsLB = new System.Windows.Forms.Label();
            this.monthclientsLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.monthDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.testsLB = new System.Windows.Forms.Label();
            this.clientsLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reestrCB = new System.Windows.Forms.ComboBox();
            this.registryBaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dayMTB = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registryBaseBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysDGV)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registryBaseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminCB
            // 
            this.adminCB.FormattingEnabled = true;
            this.adminCB.Location = new System.Drawing.Point(78, 6);
            this.adminCB.Name = "adminCB";
            this.adminCB.Size = new System.Drawing.Size(208, 21);
            this.adminCB.TabIndex = 0;
            this.adminCB.SelectedIndexChanged += new System.EventHandler(this.adminCB_SelectedIndexChanged);
            // 
            // registryBaseBindingSource
            // 
            this.registryBaseBindingSource.DataMember = "RegistryBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 610);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dayMTB);
            this.tabPage3.Controls.Add(this.daysDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(836, 584);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "День";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // daysDGV
            // 
            this.daysDGV.AllowUserToAddRows = false;
            this.daysDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.daysDGV.BackgroundColor = System.Drawing.Color.White;
            this.daysDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daysDGV.Location = new System.Drawing.Point(6, 33);
            this.daysDGV.MultiSelect = false;
            this.daysDGV.Name = "daysDGV";
            this.daysDGV.RowHeadersVisible = false;
            this.daysDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daysDGV.Size = new System.Drawing.Size(824, 545);
            this.daysDGV.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.monthtestsLB);
            this.tabPage4.Controls.Add(this.monthclientsLB);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.monthDGV);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.monthCB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(836, 584);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Месяц";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // monthtestsLB
            // 
            this.monthtestsLB.AutoSize = true;
            this.monthtestsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthtestsLB.ForeColor = System.Drawing.Color.Red;
            this.monthtestsLB.Location = new System.Drawing.Point(653, 14);
            this.monthtestsLB.Name = "monthtestsLB";
            this.monthtestsLB.Size = new System.Drawing.Size(0, 13);
            this.monthtestsLB.TabIndex = 7;
            // 
            // monthclientsLB
            // 
            this.monthclientsLB.AutoSize = true;
            this.monthclientsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthclientsLB.ForeColor = System.Drawing.Color.Red;
            this.monthclientsLB.Location = new System.Drawing.Point(422, 14);
            this.monthclientsLB.Name = "monthclientsLB";
            this.monthclientsLB.Size = new System.Drawing.Size(0, 13);
            this.monthclientsLB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пациентов:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Тестов:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthDGV
            // 
            this.monthDGV.AllowUserToAddRows = false;
            this.monthDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monthDGV.BackgroundColor = System.Drawing.Color.White;
            this.monthDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDGV.Location = new System.Drawing.Point(6, 37);
            this.monthDGV.MultiSelect = false;
            this.monthDGV.Name = "monthDGV";
            this.monthDGV.RowHeadersVisible = false;
            this.monthDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monthDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthDGV.ShowEditingIcon = false;
            this.monthDGV.Size = new System.Drawing.Size(827, 544);
            this.monthDGV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Месяц";
            // 
            // monthCB
            // 
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(49, 10);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(221, 21);
            this.monthCB.TabIndex = 0;
            this.monthCB.SelectedIndexChanged += new System.EventHandler(this.monthCB_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.testsLB);
            this.tabPage1.Controls.Add(this.clientsLB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.reestrCB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 584);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Реестр";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testsLB
            // 
            this.testsLB.AutoSize = true;
            this.testsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testsLB.ForeColor = System.Drawing.Color.Red;
            this.testsLB.Location = new System.Drawing.Point(429, 233);
            this.testsLB.Name = "testsLB";
            this.testsLB.Size = new System.Drawing.Size(0, 13);
            this.testsLB.TabIndex = 5;
            // 
            // clientsLB
            // 
            this.clientsLB.AutoSize = true;
            this.clientsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsLB.ForeColor = System.Drawing.Color.Red;
            this.clientsLB.Location = new System.Drawing.Point(439, 211);
            this.clientsLB.Name = "clientsLB";
            this.clientsLB.Size = new System.Drawing.Size(0, 13);
            this.clientsLB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пациентов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тестов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Реестр";
            // 
            // reestrCB
            // 
            this.reestrCB.FormattingEnabled = true;
            this.reestrCB.Location = new System.Drawing.Point(330, 128);
            this.reestrCB.Name = "reestrCB";
            this.reestrCB.Size = new System.Drawing.Size(141, 21);
            this.reestrCB.TabIndex = 0;
            // 
            // dayMTB
            // 
            this.dayMTB.Location = new System.Drawing.Point(45, 6);
            this.dayMTB.Mask = "00/00/0000";
            this.dayMTB.Name = "dayMTB";
            this.dayMTB.Size = new System.Drawing.Size(124, 20);
            this.dayMTB.TabIndex = 1;
            this.dayMTB.ValidatingType = typeof(System.DateTime);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Дата";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 655);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Report";
            this.Text = "ОМС - Отчеты";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registryBaseBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysDGV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registryBaseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox adminCB;
        private System.Windows.Forms.BindingSource registryBaseBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox reestrCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label testsLB;
        private System.Windows.Forms.Label clientsLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.DataGridView monthDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label monthtestsLB;
        private System.Windows.Forms.Label monthclientsLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource registryBaseBindingSource1;
        private System.Windows.Forms.DataGridView daysDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox dayMTB;
        private System.Windows.Forms.Label label8;
    }
}

