namespace Meztli
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblParte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVendorCode = new System.Windows.Forms.ComboBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.serialTo = new System.Windows.Forms.NumericUpDown();
            this.btnPartsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParte
            // 
            this.lblParte.AutoSize = true;
            this.lblParte.Location = new System.Drawing.Point(81, 57);
            this.lblParte.Name = "lblParte";
            this.lblParte.Size = new System.Drawing.Size(35, 13);
            this.lblParte.TabIndex = 0;
            this.lblParte.Text = "Parte:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(77, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(45, 126);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(72, 13);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "Vendor Code:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(79, 161);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(122, 54);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(270, 21);
            this.cmbPart.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(123, 87);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(269, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // cmbVendorCode
            // 
            this.cmbVendorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendorCode.FormattingEnabled = true;
            this.cmbVendorCode.Items.AddRange(new object[] {
            "TSPL"});
            this.cmbVendorCode.Location = new System.Drawing.Point(122, 123);
            this.cmbVendorCode.Name = "cmbVendorCode";
            this.cmbVendorCode.Size = new System.Drawing.Size(270, 21);
            this.cmbVendorCode.TabIndex = 8;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "Dia",
            "Noche"});
            this.cmbShift.Location = new System.Drawing.Point(123, 158);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(177, 21);
            this.cmbShift.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 242);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 47);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(181, 292);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Serial desde:";
            // 
            // serialFrom
            // 
            this.serialFrom.Location = new System.Drawing.Point(122, 197);
            this.serialFrom.Margin = new System.Windows.Forms.Padding(2);
            this.serialFrom.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.serialFrom.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.serialFrom.Name = "serialFrom";
            this.serialFrom.Size = new System.Drawing.Size(80, 20);
            this.serialFrom.TabIndex = 19;
            this.serialFrom.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Serial hasta:";
            // 
            // serialTo
            // 
            this.serialTo.Location = new System.Drawing.Point(298, 197);
            this.serialTo.Margin = new System.Windows.Forms.Padding(2);
            this.serialTo.Maximum = new decimal(new int[] {
            2000001,
            0,
            0,
            0});
            this.serialTo.Minimum = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            this.serialTo.Name = "serialTo";
            this.serialTo.Size = new System.Drawing.Size(92, 20);
            this.serialTo.TabIndex = 21;
            this.serialTo.Value = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            // 
            // btnPartsForm
            // 
            this.btnPartsForm.Location = new System.Drawing.Point(398, 52);
            this.btnPartsForm.Name = "btnPartsForm";
            this.btnPartsForm.Size = new System.Drawing.Size(75, 23);
            this.btnPartsForm.TabIndex = 22;
            this.btnPartsForm.Text = "Partes";
            this.btnPartsForm.UseVisualStyleBackColor = true;
            this.btnPartsForm.Click += new System.EventHandler(this.btnPartsForm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.btnPartsForm);
            this.Controls.Add(this.serialTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbVendorCode);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblParte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Meztli 1.2";
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbVendorCode;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown serialFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown serialTo;
        private System.Windows.Forms.Button btnPartsForm;
    }
}

