namespace Vybor_noutbuka
{
    partial class Bluetooth
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.notebookDataSet3 = new Vybor_noutbuka.notebookDataSet3();
            this.bluetoothBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bluetoothTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.bluetoothTableAdapter();
            this.bluetoothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbluetoothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetoothBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bluetoothDataGridViewTextBoxColumn,
            this.idbluetoothDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bluetoothBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(151, 94);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notebookDataSet3
            // 
            this.notebookDataSet3.DataSetName = "notebookDataSet3";
            this.notebookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bluetoothBindingSource
            // 
            this.bluetoothBindingSource.DataMember = "bluetooth";
            this.bluetoothBindingSource.DataSource = this.notebookDataSet3;
            // 
            // bluetoothTableAdapter
            // 
            this.bluetoothTableAdapter.ClearBeforeFill = true;
            // 
            // bluetoothDataGridViewTextBoxColumn
            // 
            this.bluetoothDataGridViewTextBoxColumn.DataPropertyName = "bluetooth";
            this.bluetoothDataGridViewTextBoxColumn.HeaderText = "bluetooth";
            this.bluetoothDataGridViewTextBoxColumn.Name = "bluetoothDataGridViewTextBoxColumn";
            this.bluetoothDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idbluetoothDataGridViewTextBoxColumn
            // 
            this.idbluetoothDataGridViewTextBoxColumn.DataPropertyName = "id_bluetooth";
            this.idbluetoothDataGridViewTextBoxColumn.HeaderText = "id_bluetooth";
            this.idbluetoothDataGridViewTextBoxColumn.Name = "idbluetoothDataGridViewTextBoxColumn";
            this.idbluetoothDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbluetoothDataGridViewTextBoxColumn.Visible = false;
            // 
            // Bluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bluetooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth";
            this.Load += new System.EventHandler(this.Bluetooth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetoothBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private notebookDataSet3 notebookDataSet3;
        private System.Windows.Forms.BindingSource bluetoothBindingSource;
        private notebookDataSet3TableAdapters.bluetoothTableAdapter bluetoothTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bluetoothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbluetoothDataGridViewTextBoxColumn;
    }
}