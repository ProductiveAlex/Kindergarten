namespace Kindergarten
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодРодителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРаботыМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИООтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРаботыОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодРебёнкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаОтцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаМатериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.родителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDataSet = new Kindergarten.KindergartenDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ребёнокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ребёнокTableAdapter = new Kindergarten.KindergartenDataSetTableAdapters.РебёнокTableAdapter();
            this.воспитателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.воспитателиTableAdapter = new Kindergarten.KindergartenDataSetTableAdapters.ВоспитателиTableAdapter();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new Kindergarten.KindergartenDataSetTableAdapters.ПерсоналTableAdapter();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new Kindergarten.KindergartenDataSetTableAdapters.ГруппаTableAdapter();
            this.родителиTableAdapter = new Kindergarten.KindergartenDataSetTableAdapters.РодителиTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ребёнокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.воспитателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripTextBox1,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 36);
            this.toolStripButton1.Text = "Добавление";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(123, 36);
            this.toolStripButton2.Text = "Редактировать";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(95, 36);
            this.toolStripButton3.Text = "Удаление";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(129, 36);
            this.toolStripButton4.Text = "Экспорт в Word";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(126, 36);
            this.toolStripButton5.Text = "Экспорт в Excel";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 39);
            this.toolStripTextBox1.Text = "Поиск данных";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(128, 36);
            this.toolStripButton6.Text = "Запросы к базе";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Сор. данных";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРодителяDataGridViewTextBoxColumn,
            this.фИОМатериDataGridViewTextBoxColumn,
            this.местоРаботыМатериDataGridViewTextBoxColumn,
            this.адрессМатериDataGridViewTextBoxColumn,
            this.фИООтцаDataGridViewTextBoxColumn,
            this.местоРаботыОтцаDataGridViewTextBoxColumn,
            this.адрессОтцаDataGridViewTextBoxColumn,
            this.кодРебёнкаDataGridViewTextBoxColumn,
            this.номерТелефонаОтцаDataGridViewTextBoxColumn,
            this.номерТелефонаМатериDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.родителиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 303);
            this.dataGridView1.TabIndex = 2;
            // 
            // кодРодителяDataGridViewTextBoxColumn
            // 
            this.кодРодителяDataGridViewTextBoxColumn.DataPropertyName = "Код родителя";
            this.кодРодителяDataGridViewTextBoxColumn.HeaderText = "Код родителя";
            this.кодРодителяDataGridViewTextBoxColumn.Name = "кодРодителяDataGridViewTextBoxColumn";
            // 
            // фИОМатериDataGridViewTextBoxColumn
            // 
            this.фИОМатериDataGridViewTextBoxColumn.DataPropertyName = "ФИО Матери";
            this.фИОМатериDataGridViewTextBoxColumn.HeaderText = "ФИО Матери";
            this.фИОМатериDataGridViewTextBoxColumn.Name = "фИОМатериDataGridViewTextBoxColumn";
            // 
            // местоРаботыМатериDataGridViewTextBoxColumn
            // 
            this.местоРаботыМатериDataGridViewTextBoxColumn.DataPropertyName = "Место работы Матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.HeaderText = "Место работы Матери";
            this.местоРаботыМатериDataGridViewTextBoxColumn.Name = "местоРаботыМатериDataGridViewTextBoxColumn";
            // 
            // адрессМатериDataGridViewTextBoxColumn
            // 
            this.адрессМатериDataGridViewTextBoxColumn.DataPropertyName = "Адресс Матери";
            this.адрессМатериDataGridViewTextBoxColumn.HeaderText = "Адресс Матери";
            this.адрессМатериDataGridViewTextBoxColumn.Name = "адрессМатериDataGridViewTextBoxColumn";
            // 
            // фИООтцаDataGridViewTextBoxColumn
            // 
            this.фИООтцаDataGridViewTextBoxColumn.DataPropertyName = "ФИО Отца";
            this.фИООтцаDataGridViewTextBoxColumn.HeaderText = "ФИО Отца";
            this.фИООтцаDataGridViewTextBoxColumn.Name = "фИООтцаDataGridViewTextBoxColumn";
            // 
            // местоРаботыОтцаDataGridViewTextBoxColumn
            // 
            this.местоРаботыОтцаDataGridViewTextBoxColumn.DataPropertyName = "Место работы Отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.HeaderText = "Место работы Отца";
            this.местоРаботыОтцаDataGridViewTextBoxColumn.Name = "местоРаботыОтцаDataGridViewTextBoxColumn";
            // 
            // адрессОтцаDataGridViewTextBoxColumn
            // 
            this.адрессОтцаDataGridViewTextBoxColumn.DataPropertyName = "Адресс Отца";
            this.адрессОтцаDataGridViewTextBoxColumn.HeaderText = "Адресс Отца";
            this.адрессОтцаDataGridViewTextBoxColumn.Name = "адрессОтцаDataGridViewTextBoxColumn";
            // 
            // кодРебёнкаDataGridViewTextBoxColumn
            // 
            this.кодРебёнкаDataGridViewTextBoxColumn.DataPropertyName = "Код ребёнка";
            this.кодРебёнкаDataGridViewTextBoxColumn.HeaderText = "Код ребёнка";
            this.кодРебёнкаDataGridViewTextBoxColumn.Name = "кодРебёнкаDataGridViewTextBoxColumn";
            // 
            // номерТелефонаОтцаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаОтцаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона Отца";
            this.номерТелефонаОтцаDataGridViewTextBoxColumn.HeaderText = "Номер телефона Отца";
            this.номерТелефонаОтцаDataGridViewTextBoxColumn.Name = "номерТелефонаОтцаDataGridViewTextBoxColumn";
            // 
            // номерТелефонаМатериDataGridViewTextBoxColumn
            // 
            this.номерТелефонаМатериDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона Матери";
            this.номерТелефонаМатериDataGridViewTextBoxColumn.HeaderText = "Номер телефона Матери";
            this.номерТелефонаМатериDataGridViewTextBoxColumn.Name = "номерТелефонаМатериDataGridViewTextBoxColumn";
            // 
            // родителиBindingSource
            // 
            this.родителиBindingSource.DataMember = "Родители";
            this.родителиBindingSource.DataSource = this.kindergartenDataSet;
            // 
            // kindergartenDataSet
            // 
            this.kindergartenDataSet.DataSetName = "KindergartenDataSet";
            this.kindergartenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(371, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(280, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(189, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ребёнокBindingSource
            // 
            this.ребёнокBindingSource.DataMember = "Ребёнок";
            this.ребёнокBindingSource.DataSource = this.kindergartenDataSet;
            // 
            // ребёнокTableAdapter
            // 
            this.ребёнокTableAdapter.ClearBeforeFill = true;
            // 
            // воспитателиBindingSource
            // 
            this.воспитателиBindingSource.DataMember = "Воспитатели";
            this.воспитателиBindingSource.DataSource = this.kindergartenDataSet;
            // 
            // воспитателиTableAdapter
            // 
            this.воспитателиTableAdapter.ClearBeforeFill = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.kindergartenDataSet;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.kindergartenDataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // родителиTableAdapter
            // 
            this.родителиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Детский сад \"Радуга\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ребёнокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.воспитателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private KindergartenDataSet kindergartenDataSet;
        private System.Windows.Forms.BindingSource ребёнокBindingSource;
        private KindergartenDataSetTableAdapters.РебёнокTableAdapter ребёнокTableAdapter;
        private System.Windows.Forms.BindingSource воспитателиBindingSource;
        private KindergartenDataSetTableAdapters.ВоспитателиTableAdapter воспитателиTableAdapter;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private KindergartenDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private KindergartenDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource родителиBindingSource;
        private KindergartenDataSetTableAdapters.РодителиTableAdapter родителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРодителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИООтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРебёнкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаОтцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаМатериDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

