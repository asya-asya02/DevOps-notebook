namespace Vybor_noutbuka
{
    partial class admin2
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
            this.notebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookTableAdapter = new Vybor_noutbuka.notebookDataSetTableAdapters.NotebookTableAdapter();
            this.tableAdapterManager1 = new Vybor_noutbuka.notebookDataSetTableAdapters.TableAdapterManager();
            this.notebookDataSet1 = new Vybor_noutbuka.notebookDataSet1();
            this.notebookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet2 = new Vybor_noutbuka.notebookDataSet2();
            this.notebookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notebookTableAdapter1 = new Vybor_noutbuka.notebookDataSet2TableAdapters.NotebookTableAdapter();
            this.notebookDataSet21 = new Vybor_noutbuka.notebookDataSet2();
            this.notebookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // notebookTableAdapter
            // 
            this.notebookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NotebookTableAdapter = this.notebookTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Vybor_noutbuka.notebookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notebookDataSet1
            // 
            this.notebookDataSet1.DataSetName = "notebookDataSet1";
            this.notebookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.notebookDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // notebookDataSet2
            // 
            this.notebookDataSet2.DataSetName = "notebookDataSet2";
            this.notebookDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notebookBindingSource1
            // 
            this.notebookBindingSource1.DataMember = "Notebook";
            this.notebookBindingSource1.DataSource = this.bindingSource1;
            // 
            // notebookTableAdapter1
            // 
            this.notebookTableAdapter1.ClearBeforeFill = true;
            // 
            // notebookDataSet21
            // 
            this.notebookDataSet21.DataSetName = "notebookDataSet2";
            this.notebookDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notebookBindingSource2
            // 
            this.notebookBindingSource2.DataMember = "Notebook";
            this.notebookBindingSource2.DataSource = this.bindingSource1;
            // 
            // admin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 365);
            this.Name = "admin2";
            this.Text = "admin2";
            this.Load += new System.EventHandler(this.admin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource notebookBindingSource;
        private notebookDataSetTableAdapters.NotebookTableAdapter notebookTableAdapter;
        private notebookDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private notebookDataSet1 notebookDataSet1;
        private System.Windows.Forms.BindingSource notebookBindingSource4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private notebookDataSet2 notebookDataSet2;
        private System.Windows.Forms.BindingSource notebookBindingSource1;
        private notebookDataSet2TableAdapters.NotebookTableAdapter notebookTableAdapter1;
        private notebookDataSet2 notebookDataSet21;
        private System.Windows.Forms.BindingSource notebookBindingSource2;
    }
}