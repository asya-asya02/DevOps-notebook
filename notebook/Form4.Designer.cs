namespace Vybor_noutbuka
{
    partial class edit_s
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet3 = new Vybor_noutbuka.notebookDataSet3();
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operativBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bluetoothBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.MoneyTableAdapter();
            this.firmTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.FirmTableAdapter();
            this.tipTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.tipTableAdapter();
            this.processorTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.ProcessorTableAdapter();
            this.operativTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.OperativTableAdapter();
            this.hDDTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.HDDTableAdapter();
            this.diskTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.DiskTableAdapter();
            this.diagonalTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.DiagonalTableAdapter();
            this.oSTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.OSTableAdapter();
            this.bluetoothTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.bluetoothTableAdapter();
            this.usingTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.UsingTableAdapter();
            this.paramTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.ParamTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notebookDataSet31 = new Vybor_noutbuka.notebookDataSet3();
            this.diagonalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetoothBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.paramBindingSource;
            this.comboBox1.DisplayMember = "param";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id_param";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // paramBindingSource
            // 
            this.paramBindingSource.DataMember = "Param";
            this.paramBindingSource.DataSource = this.notebookDataSet3;
            // 
            // notebookDataSet3
            // 
            this.notebookDataSet3.DataSetName = "notebookDataSet3";
            this.notebookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyBindingSource
            // 
            this.moneyBindingSource.DataMember = "Money";
            this.moneyBindingSource.DataSource = this.notebookDataSet3;
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataMember = "Firm";
            this.firmBindingSource.DataSource = this.notebookDataSet3;
            // 
            // tipBindingSource
            // 
            this.tipBindingSource.DataMember = "tip";
            this.tipBindingSource.DataSource = this.notebookDataSet3;
            // 
            // processorBindingSource
            // 
            this.processorBindingSource.DataMember = "Processor";
            this.processorBindingSource.DataSource = this.notebookDataSet3;
            // 
            // operativBindingSource
            // 
            this.operativBindingSource.DataMember = "Operativ";
            this.operativBindingSource.DataSource = this.notebookDataSet3;
            // 
            // hDDBindingSource
            // 
            this.hDDBindingSource.DataMember = "HDD";
            this.hDDBindingSource.DataSource = this.notebookDataSet3;
            // 
            // diskBindingSource
            // 
            this.diskBindingSource.DataMember = "Disk";
            this.diskBindingSource.DataSource = this.notebookDataSet3;
            // 
            // diagonalBindingSource
            // 
            this.diagonalBindingSource.DataMember = "Diagonal";
            this.diagonalBindingSource.DataSource = this.notebookDataSet3;
            // 
            // oSBindingSource
            // 
            this.oSBindingSource.DataMember = "OS";
            this.oSBindingSource.DataSource = this.notebookDataSet3;
            // 
            // bluetoothBindingSource
            // 
            this.bluetoothBindingSource.DataMember = "bluetooth";
            this.bluetoothBindingSource.DataSource = this.notebookDataSet3;
            // 
            // usingBindingSource
            // 
            this.usingBindingSource.DataMember = "Using";
            this.usingBindingSource.DataSource = this.notebookDataSet3;
            // 
            // moneyTableAdapter
            // 
            this.moneyTableAdapter.ClearBeforeFill = true;
            // 
            // firmTableAdapter
            // 
            this.firmTableAdapter.ClearBeforeFill = true;
            // 
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // processorTableAdapter
            // 
            this.processorTableAdapter.ClearBeforeFill = true;
            // 
            // operativTableAdapter
            // 
            this.operativTableAdapter.ClearBeforeFill = true;
            // 
            // hDDTableAdapter
            // 
            this.hDDTableAdapter.ClearBeforeFill = true;
            // 
            // diskTableAdapter
            // 
            this.diskTableAdapter.ClearBeforeFill = true;
            // 
            // diagonalTableAdapter
            // 
            this.diagonalTableAdapter.ClearBeforeFill = true;
            // 
            // oSTableAdapter
            // 
            this.oSTableAdapter.ClearBeforeFill = true;
            // 
            // bluetoothTableAdapter
            // 
            this.bluetoothTableAdapter.ClearBeforeFill = true;
            // 
            // usingTableAdapter
            // 
            this.usingTableAdapter.ClearBeforeFill = true;
            // 
            // paramTableAdapter
            // 
            this.paramTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(200, 200);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // notebookDataSet31
            // 
            this.notebookDataSet31.DataSetName = "notebookDataSet3";
            this.notebookDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagonalBindingSource1
            // 
            this.diagonalBindingSource1.DataMember = "Diagonal";
            this.diagonalBindingSource1.DataSource = this.notebookDataSet31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 72);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Новая запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // edit_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 321);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "edit_s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор параметров";
            this.Load += new System.EventHandler(this.edit_s_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetoothBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private notebookDataSet3 notebookDataSet3;
        private System.Windows.Forms.BindingSource moneyBindingSource;
        private notebookDataSet3TableAdapters.MoneyTableAdapter moneyTableAdapter;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private notebookDataSet3TableAdapters.FirmTableAdapter firmTableAdapter;
        private System.Windows.Forms.BindingSource tipBindingSource;
        private notebookDataSet3TableAdapters.tipTableAdapter tipTableAdapter;
        private System.Windows.Forms.BindingSource processorBindingSource;
        private notebookDataSet3TableAdapters.ProcessorTableAdapter processorTableAdapter;
        private System.Windows.Forms.BindingSource operativBindingSource;
        private notebookDataSet3TableAdapters.OperativTableAdapter operativTableAdapter;
        private System.Windows.Forms.BindingSource hDDBindingSource;
        private notebookDataSet3TableAdapters.HDDTableAdapter hDDTableAdapter;
        private System.Windows.Forms.BindingSource diskBindingSource;
        private notebookDataSet3TableAdapters.DiskTableAdapter diskTableAdapter;
        private System.Windows.Forms.BindingSource diagonalBindingSource;
        private notebookDataSet3TableAdapters.DiagonalTableAdapter diagonalTableAdapter;
        private System.Windows.Forms.BindingSource oSBindingSource;
        private notebookDataSet3TableAdapters.OSTableAdapter oSTableAdapter;
        private System.Windows.Forms.BindingSource bluetoothBindingSource;
        private notebookDataSet3TableAdapters.bluetoothTableAdapter bluetoothTableAdapter;
        private System.Windows.Forms.BindingSource usingBindingSource;
        private notebookDataSet3TableAdapters.UsingTableAdapter usingTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource paramBindingSource;
        private notebookDataSet3TableAdapters.ParamTableAdapter paramTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private notebookDataSet3 notebookDataSet31;
        private System.Windows.Forms.BindingSource diagonalBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}