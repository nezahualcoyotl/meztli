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
            this.lblSerial = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVendorCode = new System.Windows.Forms.ComboBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.cmbSerialNumber = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtFinalCode = new System.Windows.Forms.TextBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.serialTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParte
            // 
            this.lblParte.AutoSize = true;
            this.lblParte.Location = new System.Drawing.Point(48, 50);
            this.lblParte.Name = "lblParte";
            this.lblParte.Size = new System.Drawing.Size(35, 13);
            this.lblParte.TabIndex = 0;
            this.lblParte.Text = "Parte:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(44, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(12, 119);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(72, 13);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "Vendor Code:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(46, 154);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(48, 189);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(36, 13);
            this.lblSerial.TabIndex = 4;
            this.lblSerial.Text = "Serial:";
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(89, 47);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(270, 21);
            this.cmbPart.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(90, 80);
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
            this.cmbVendorCode.Location = new System.Drawing.Point(89, 116);
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
            this.cmbShift.Location = new System.Drawing.Point(90, 151);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(177, 21);
            this.cmbShift.TabIndex = 9;
            // 
            // cmbSerialNumber
            // 
            this.cmbSerialNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialNumber.FormattingEnabled = true;
            this.cmbSerialNumber.Items.AddRange(new object[] {
            "151208"});
            this.cmbSerialNumber.Location = new System.Drawing.Point(90, 186);
            this.cmbSerialNumber.Name = "cmbSerialNumber";
            this.cmbSerialNumber.Size = new System.Drawing.Size(269, 21);
            this.cmbSerialNumber.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(90, 255);
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
            this.lblWarning.Location = new System.Drawing.Point(124, 279);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 14;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(36, 565);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(47, 13);
            this.lblCadena.TabIndex = 5;
            this.lblCadena.Text = "Cadena:";
            this.lblCadena.Visible = false;
            // 
            // txtFinalCode
            // 
            this.txtFinalCode.Location = new System.Drawing.Point(89, 562);
            this.txtFinalCode.Name = "txtFinalCode";
            this.txtFinalCode.Size = new System.Drawing.Size(269, 20);
            this.txtFinalCode.TabIndex = 11;
            this.txtFinalCode.Visible = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(12, 308);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(409, 214);
            this.pbQRCode.TabIndex = 13;
            this.pbQRCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Serial desde:";
            // 
            // serialFrom
            // 
            this.serialFrom.Location = new System.Drawing.Point(90, 220);
            this.serialFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label2.Location = new System.Drawing.Point(197, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Serial hasta:";
            // 
            // serialTo
            // 
            this.serialTo.Location = new System.Drawing.Point(266, 220);
            this.serialTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 594);
            this.Controls.Add(this.serialTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtFinalCode);
            this.Controls.Add(this.cmbSerialNumber);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbVendorCode);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblParte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meztli 1.2";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
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
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbVendorCode;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.ComboBox cmbSerialNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.TextBox txtFinalCode;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown serialFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown serialTo;
    }
}

