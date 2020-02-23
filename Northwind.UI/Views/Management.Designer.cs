namespace Northwind.UI.Views
{
    partial class Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.lblClose = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.complaintsView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.managersView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.facilityManagerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status = new Bunifu.UI.WinForms.BunifuDropdown();
            this.location = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Location = new System.Drawing.Point(1138, 8);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.OnClose);
            this.lblClose.MouseEnter += new System.EventHandler(this.OnHover);
            this.lblClose.MouseLeave += new System.EventHandler(this.OnHoverLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(29, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 39);
            this.label9.TabIndex = 6;
            this.label9.Text = "Management Portal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Complaints:";
            // 
            // complaintsView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.complaintsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.complaintsView.AutoGenerateColumns = false;
            this.complaintsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.complaintsView.BackgroundColor = System.Drawing.Color.White;
            this.complaintsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.complaintsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.complaintsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.complaintsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.complaintsView.DataSource = this.complainBindingSource;
            this.complaintsView.DoubleBuffered = true;
            this.complaintsView.EnableHeadersVisualStyles = false;
            this.complaintsView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.complaintsView.HeaderForeColor = System.Drawing.Color.White;
            this.complaintsView.Location = new System.Drawing.Point(36, 136);
            this.complaintsView.Name = "complaintsView";
            this.complaintsView.ReadOnly = true;
            this.complaintsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.complaintsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.complaintsView.RowTemplate.Height = 25;
            this.complaintsView.RowTemplate.ReadOnly = true;
            this.complaintsView.Size = new System.Drawing.Size(526, 507);
            this.complaintsView.TabIndex = 27;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ComplainID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Date";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainBindingSource
            // 
            this.complainBindingSource.DataSource = typeof(Northwind.Common.Model.Complain);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(602, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Managers:";
            // 
            // managersView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.managersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.managersView.AutoGenerateColumns = false;
            this.managersView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.managersView.BackgroundColor = System.Drawing.Color.White;
            this.managersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.managersView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.managersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.managersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilityManagerIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.managersView.DataSource = this.facilityManagerBindingSource;
            this.managersView.DoubleBuffered = true;
            this.managersView.EnableHeadersVisualStyles = false;
            this.managersView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.managersView.HeaderForeColor = System.Drawing.Color.White;
            this.managersView.Location = new System.Drawing.Point(607, 136);
            this.managersView.Name = "managersView";
            this.managersView.ReadOnly = true;
            this.managersView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.managersView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.managersView.RowTemplate.Height = 25;
            this.managersView.RowTemplate.ReadOnly = true;
            this.managersView.Size = new System.Drawing.Size(543, 507);
            this.managersView.TabIndex = 29;
            // 
            // facilityManagerIDDataGridViewTextBoxColumn
            // 
            this.facilityManagerIDDataGridViewTextBoxColumn.DataPropertyName = "FacilityManagerID";
            this.facilityManagerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.facilityManagerIDDataGridViewTextBoxColumn.Name = "facilityManagerIDDataGridViewTextBoxColumn";
            this.facilityManagerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facilityManagerBindingSource
            // 
            this.facilityManagerBindingSource.DataSource = typeof(Northwind.Common.Model.FacilityManager);
            // 
            // status
            // 
            this.status.AutoCompleteCustomSource.AddRange(new string[] {
            "Completed",
            "Pending"});
            this.status.BackColor = System.Drawing.SystemColors.Control;
            this.status.BorderRadius = 1;
            this.status.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.status.DisabledColor = System.Drawing.Color.Gray;
            this.status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.status.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.status.FillDropDown = false;
            this.status.FillIndicator = false;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.FormattingEnabled = true;
            this.status.Icon = null;
            this.status.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.status.ItemBackColor = System.Drawing.Color.White;
            this.status.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.ItemHeight = 26;
            this.status.ItemHighLightColor = System.Drawing.Color.White;
            this.status.Items.AddRange(new object[] {
            "Pending",
            "Closed"});
            this.status.Location = new System.Drawing.Point(248, 98);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(125, 32);
            this.status.TabIndex = 30;
            this.status.Text = null;
            this.status.SelectedIndexChanged += new System.EventHandler(this.BunifuDropdown1_SelectedIndexChanged);
            // 
            // location
            // 
            this.location.AutoCompleteCustomSource.AddRange(new string[] {
            "CDS",
            "CST",
            "COE",
            "Senate",
            "Medical Center",
            "Residential Apartment",
            "Hostel",
            "Others"});
            this.location.BackColor = System.Drawing.SystemColors.Control;
            this.location.BorderRadius = 1;
            this.location.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.location.DisabledColor = System.Drawing.Color.Gray;
            this.location.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.location.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.location.FillDropDown = false;
            this.location.FillIndicator = false;
            this.location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.location.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.FormattingEnabled = true;
            this.location.Icon = null;
            this.location.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.location.ItemBackColor = System.Drawing.Color.White;
            this.location.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location.ItemHeight = 26;
            this.location.ItemHighLightColor = System.Drawing.Color.White;
            this.location.Items.AddRange(new object[] {
            "CDS",
            "CST",
            "COE",
            "Medical Center",
            "Health Center",
            "Senate",
            "Hostel",
            "Others"});
            this.location.Location = new System.Drawing.Point(379, 98);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(136, 32);
            this.location.TabIndex = 31;
            this.location.Text = null;
            this.location.SelectedIndexChanged += new System.EventHandler(this.BunifuDropdown2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(245, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(376, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1072, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sign Out";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.OnHover);
            this.label5.MouseLeave += new System.EventHandler(this.OnHoverLeave);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.status);
            this.Controls.Add(this.managersView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.complaintsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Management";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.complaintsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid managersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityManagerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facilityManagerBindingSource;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid complaintsView;
        private System.Windows.Forms.BindingSource complainBindingSource;
        private Bunifu.UI.WinForms.BunifuDropdown location;
        private Bunifu.UI.WinForms.BunifuDropdown status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}