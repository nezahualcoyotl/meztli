namespace Meztli
{
    partial class Parts
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
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meztlidbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meztlidbDataSet = new Meztli.meztlidbDataSet();
            this.partTableAdapter = new Meztli.meztlidbDataSetTableAdapters.PartTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumbersalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.meztlidbDataSetBindingSource;
            // 
            // meztlidbDataSetBindingSource
            // 
            this.meztlidbDataSetBindingSource.DataSource = this.meztlidbDataSet;
            this.meztlidbDataSetBindingSource.Position = 0;
            // 
            // meztlidbDataSet
            // 
            this.meztlidbDataSet.DataSetName = "meztlidbDataSet";
            this.meztlidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.partnumberDataGridViewTextBoxColumn,
            this.partnumbersalesDataGridViewTextBoxColumn,
            this.partnameDataGridViewTextBoxColumn,
            this.pngDataGridViewTextBoxColumn,
            this.pacDataGridViewTextBoxColumn,
            this.packgDataGridViewTextBoxColumn,
            this.cavDataGridViewTextBoxColumn,
            this.equipDataGridViewTextBoxColumn,
            this.displaynameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1569, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 150;
            // 
            // partnumberDataGridViewTextBoxColumn
            // 
            this.partnumberDataGridViewTextBoxColumn.DataPropertyName = "part_number";
            this.partnumberDataGridViewTextBoxColumn.HeaderText = "part_number";
            this.partnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partnumberDataGridViewTextBoxColumn.Name = "partnumberDataGridViewTextBoxColumn";
            this.partnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // partnumbersalesDataGridViewTextBoxColumn
            // 
            this.partnumbersalesDataGridViewTextBoxColumn.DataPropertyName = "part_number_sales";
            this.partnumbersalesDataGridViewTextBoxColumn.HeaderText = "part_number_sales";
            this.partnumbersalesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partnumbersalesDataGridViewTextBoxColumn.Name = "partnumbersalesDataGridViewTextBoxColumn";
            this.partnumbersalesDataGridViewTextBoxColumn.Width = 150;
            // 
            // partnameDataGridViewTextBoxColumn
            // 
            this.partnameDataGridViewTextBoxColumn.DataPropertyName = "part_name";
            this.partnameDataGridViewTextBoxColumn.HeaderText = "part_name";
            this.partnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partnameDataGridViewTextBoxColumn.Name = "partnameDataGridViewTextBoxColumn";
            this.partnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pngDataGridViewTextBoxColumn
            // 
            this.pngDataGridViewTextBoxColumn.DataPropertyName = "png";
            this.pngDataGridViewTextBoxColumn.HeaderText = "png";
            this.pngDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pngDataGridViewTextBoxColumn.Name = "pngDataGridViewTextBoxColumn";
            this.pngDataGridViewTextBoxColumn.Width = 150;
            // 
            // pacDataGridViewTextBoxColumn
            // 
            this.pacDataGridViewTextBoxColumn.DataPropertyName = "pac";
            this.pacDataGridViewTextBoxColumn.HeaderText = "pac";
            this.pacDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pacDataGridViewTextBoxColumn.Name = "pacDataGridViewTextBoxColumn";
            this.pacDataGridViewTextBoxColumn.Width = 150;
            // 
            // packgDataGridViewTextBoxColumn
            // 
            this.packgDataGridViewTextBoxColumn.DataPropertyName = "pac_kg";
            this.packgDataGridViewTextBoxColumn.HeaderText = "pac_kg";
            this.packgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.packgDataGridViewTextBoxColumn.Name = "packgDataGridViewTextBoxColumn";
            this.packgDataGridViewTextBoxColumn.Width = 150;
            // 
            // cavDataGridViewTextBoxColumn
            // 
            this.cavDataGridViewTextBoxColumn.DataPropertyName = "cav";
            this.cavDataGridViewTextBoxColumn.HeaderText = "cav";
            this.cavDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cavDataGridViewTextBoxColumn.Name = "cavDataGridViewTextBoxColumn";
            this.cavDataGridViewTextBoxColumn.Width = 150;
            // 
            // equipDataGridViewTextBoxColumn
            // 
            this.equipDataGridViewTextBoxColumn.DataPropertyName = "equip";
            this.equipDataGridViewTextBoxColumn.HeaderText = "equip";
            this.equipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.equipDataGridViewTextBoxColumn.Name = "equipDataGridViewTextBoxColumn";
            this.equipDataGridViewTextBoxColumn.Width = 150;
            // 
            // displaynameDataGridViewTextBoxColumn
            // 
            this.displaynameDataGridViewTextBoxColumn.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn.HeaderText = "display_name";
            this.displaynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.displaynameDataGridViewTextBoxColumn.Name = "displaynameDataGridViewTextBoxColumn";
            this.displaynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 386);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Guardar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 421);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Parts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource meztlidbDataSetBindingSource;
        private meztlidbDataSet meztlidbDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private meztlidbDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumbersalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}