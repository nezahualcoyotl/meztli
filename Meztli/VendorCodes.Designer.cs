
namespace Meztli
{
    partial class VendorCodes
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
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meztlidbDataSet = new Meztli.meztlidbDataSet();
            this.vendorTableAdapter = new Meztli.meztlidbDataSetTableAdapters.VendorTableAdapter();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendor
            // 
            this.dgvVendor.AutoGenerateColumns = false;
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn});
            this.dgvVendor.DataSource = this.vendorBindingSource;
            this.dgvVendor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvVendor.Location = new System.Drawing.Point(12, 12);
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.Size = new System.Drawing.Size(196, 202);
            this.dgvVendor.TabIndex = 0;
            this.dgvVendor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendor_CellEnter);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.meztlidbDataSet;
            // 
            // meztlidbDataSet
            // 
            this.meztlidbDataSet.DataSetName = "meztlidbDataSet";
            this.meztlidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Gray;
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveChanges.Location = new System.Drawing.Point(134, 220);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "SAVE";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteRows.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRows.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteRows.Location = new System.Drawing.Point(12, 220);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(108, 23);
            this.btnDeleteRows.TabIndex = 3;
            this.btnDeleteRows.Text = "DELETE ROW";
            this.btnDeleteRows.UseVisualStyleBackColor = false;
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRows_Click);
            // 
            // VendorCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(221, 255);
            this.Controls.Add(this.btnDeleteRows);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvVendor);
            this.Name = "VendorCodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDOR CODES";
            this.Load += new System.EventHandler(this.VendorCodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendor;
        private meztlidbDataSet meztlidbDataSet;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private meztlidbDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteRows;
    }
}