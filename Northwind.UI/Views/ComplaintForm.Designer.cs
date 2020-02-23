namespace Northwind.UI.Views
{
    partial class ComplaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplaintForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdownType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.dropdownStatus = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdownLocaton = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblDate = new System.Windows.Forms.Label();
            this.datepickerDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblError = new System.Windows.Forms.Label();
            this.complaintSubmitedPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.complaintSubmitedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 25;
            this.elipse.TargetControl = this;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Location = new System.Drawing.Point(1021, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.OnClick);
            this.lblClose.MouseEnter += new System.EventHandler(this.OnHover);
            this.lblClose.MouseLeave += new System.EventHandler(this.OnHoverLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(20, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 39);
            this.label11.TabIndex = 10;
            this.label11.Text = "New Complaint\r\n";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(27, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoWordSelection = true;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(27, 240);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(506, 317);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(572, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type:";
            // 
            // dropdownType
            // 
            this.dropdownType.BackColor = System.Drawing.Color.White;
            this.dropdownType.BorderRadius = 1;
            this.dropdownType.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownType.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropdownType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownType.FillDropDown = false;
            this.dropdownType.FillIndicator = false;
            this.dropdownType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.FormattingEnabled = true;
            this.dropdownType.Icon = null;
            this.dropdownType.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownType.ItemBackColor = System.Drawing.Color.White;
            this.dropdownType.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.ItemHeight = 26;
            this.dropdownType.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownType.Items.AddRange(new object[] {
            "Electrical",
            "Plumbing",
            "Capentry",
            "Tiling",
            "MasonWork",
            "Tiling",
            "Others"});
            this.dropdownType.Location = new System.Drawing.Point(579, 176);
            this.dropdownType.Name = "dropdownType";
            this.dropdownType.Size = new System.Drawing.Size(386, 32);
            this.dropdownType.TabIndex = 23;
            this.dropdownType.Text = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(572, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 24;
            this.label3.Text = "Status:";
            // 
            // dropdownStatus
            // 
            this.dropdownStatus.BackColor = System.Drawing.Color.White;
            this.dropdownStatus.BorderRadius = 1;
            this.dropdownStatus.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownStatus.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownStatus.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropdownStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownStatus.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownStatus.FillDropDown = false;
            this.dropdownStatus.FillIndicator = false;
            this.dropdownStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.FormattingEnabled = true;
            this.dropdownStatus.Icon = null;
            this.dropdownStatus.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownStatus.ItemBackColor = System.Drawing.Color.White;
            this.dropdownStatus.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.ItemHeight = 26;
            this.dropdownStatus.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownStatus.Items.AddRange(new object[] {
            "Pending",
            "Closed"});
            this.dropdownStatus.Location = new System.Drawing.Point(579, 282);
            this.dropdownStatus.Name = "dropdownStatus";
            this.dropdownStatus.Size = new System.Drawing.Size(386, 32);
            this.dropdownStatus.TabIndex = 25;
            this.dropdownStatus.Text = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(572, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Location:";
            // 
            // dropdownLocaton
            // 
            this.dropdownLocaton.BackColor = System.Drawing.Color.White;
            this.dropdownLocaton.BorderRadius = 1;
            this.dropdownLocaton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownLocaton.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownLocaton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownLocaton.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropdownLocaton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownLocaton.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownLocaton.FillDropDown = false;
            this.dropdownLocaton.FillIndicator = false;
            this.dropdownLocaton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownLocaton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownLocaton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.FormattingEnabled = true;
            this.dropdownLocaton.Icon = null;
            this.dropdownLocaton.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownLocaton.ItemBackColor = System.Drawing.Color.White;
            this.dropdownLocaton.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.ItemHeight = 26;
            this.dropdownLocaton.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLocaton.Items.AddRange(new object[] {
            "CST",
            "COE",
            "CDS",
            "Senate",
            "Medical Center",
            "Residential Apartment",
            "Hostel",
            "Others"});
            this.dropdownLocaton.Location = new System.Drawing.Point(579, 396);
            this.dropdownLocaton.Name = "dropdownLocaton";
            this.dropdownLocaton.Size = new System.Drawing.Size(386, 32);
            this.dropdownLocaton.TabIndex = 27;
            this.dropdownLocaton.Text = null;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(572, 460);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 39);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date:";
            // 
            // datepickerDate
            // 
            this.datepickerDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datepickerDate.BorderRadius = 0;
            this.datepickerDate.ForeColor = System.Drawing.Color.White;
            this.datepickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerDate.FormatCustom = null;
            this.datepickerDate.Location = new System.Drawing.Point(579, 502);
            this.datepickerDate.Name = "datepickerDate";
            this.datepickerDate.Size = new System.Drawing.Size(386, 36);
            this.datepickerDate.TabIndex = 29;
            this.datepickerDate.Value = new System.DateTime(2019, 4, 10, 17, 40, 36, 994);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(880, 617);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(85, 72);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 30;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(23, 164);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(185, 18);
            this.lblError.TabIndex = 31;
            this.lblError.Text = "Description cannot be empty\r\n";
            // 
            // complaintSubmitedPanel
            // 
            this.complaintSubmitedPanel.Controls.Add(this.label5);
            this.complaintSubmitedPanel.Controls.Add(this.pictureBox1);
            this.complaintSubmitedPanel.Location = new System.Drawing.Point(27, 12);
            this.complaintSubmitedPanel.Name = "complaintSubmitedPanel";
            this.complaintSubmitedPanel.Size = new System.Drawing.Size(987, 677);
            this.complaintSubmitedPanel.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(370, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complaint Submited!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 717);
            this.Controls.Add(this.complaintSubmitedPanel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.datepickerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dropdownLocaton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropdownStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropdownType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComplaintForm";
            this.Text = "ComplaintForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.complaintSubmitedPanel.ResumeLayout(false);
            this.complaintSubmitedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownType;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownStatus;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker datepickerDate;
        private System.Windows.Forms.Label lblDate;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownLocaton;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel complaintSubmitedPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}