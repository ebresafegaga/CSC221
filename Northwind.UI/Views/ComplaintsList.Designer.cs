namespace Northwind.UI.Views
{
    partial class ComplaintsList
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container ();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager (typeof (Northwind.UI.Views.ComplaintsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle ();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                new System.Windows.Forms.DataGridViewCellStyle ();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl (this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse (this.components);
            this.lblClose = new System.Windows.Forms.Label ();
            this.label11 = new System.Windows.Forms.Label ();
            this.label1 = new System.Windows.Forms.Label ();
            this.dropdownFilter = new Bunifu.UI.WinForms.BunifuDropdown ();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton ();
            this.listview = new Bunifu.Framework.UI.BunifuCustomDataGrid ();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.complainBindingSource = new System.Windows.Forms.BindingSource (this.components);
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown ();
            this.label2 = new System.Windows.Forms.Label ();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton1)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.listview)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.complainBindingSource)).BeginInit ();
            this.SuspendLayout ();
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font ("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.lblClose.Location = new System.Drawing.Point (1191, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size (24, 25);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler (this.OnClick);
            this.lblClose.MouseEnter += new System.EventHandler (this.OnHover);
            this.lblClose.MouseLeave += new System.EventHandler (this.OnHoverLeave);
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font ("Calibri", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.label11.Location = new System.Drawing.Point (34, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size (164, 78);
            this.label11.TabIndex = 11;
            this.label11.Text = "Complaints\r\n\r\n";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Calibri", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.label1.Location = new System.Drawing.Point (764, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (134, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter Location";
            this.dropdownFilter.BackColor = System.Drawing.SystemColors.Control;
            this.dropdownFilter.BorderRadius = 1;
            this.dropdownFilter.Color = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.dropdownFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownFilter.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropdownFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownFilter.FillDropDown = false;
            this.dropdownFilter.FillIndicator = false;
            this.dropdownFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownFilter.Font = new System.Drawing.Font ("Calibri", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dropdownFilter.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dropdownFilter.FormattingEnabled = true;
            this.dropdownFilter.Icon = null;
            this.dropdownFilter.IndicatorColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dropdownFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownFilter.ItemBackColor = System.Drawing.Color.White;
            this.dropdownFilter.ItemBorderColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dropdownFilter.ItemForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dropdownFilter.ItemHeight = 26;
            this.dropdownFilter.ItemHighLightColor = System.Drawing.Color.White;
            this.dropdownFilter.Items.AddRange (new object[]
                {"Electrical", "Plumbing", "Capentry", "Tiling", "MasonWork", "Tiling", "Others"});
            this.dropdownFilter.Location = new System.Drawing.Point (989, 82);
            this.dropdownFilter.Name = "dropdownFilter";
            this.dropdownFilter.Size = new System.Drawing.Size (200, 32);
            this.dropdownFilter.TabIndex = 24;
            this.dropdownFilter.Text = null;
            this.dropdownFilter.SelectedIndexChanged +=
                new System.EventHandler (this.DropdownFilter_SelectedIndexChanged);
            this.bunifuImageButton1.Image = ((System.Drawing.Image) (resources.GetObject ("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point (42, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size (56, 43);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler (this.BunifuImageButton1_Click);
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (224)))),
                ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.listview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listview.AutoGenerateColumns = false;
            this.listview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listview.BackgroundColor = System.Drawing.Color.White;
            this.listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font ("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listview.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listview.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[]
            {
                this.ID, this.descriptionDataGridViewTextBoxColumn, this.typeDataGridViewTextBoxColumn,
                this.timeDataGridViewTextBoxColumn, this.statusDataGridViewTextBoxColumn,
                this.locationDataGridViewTextBoxColumn
            });
            this.listview.DataSource = this.complainBindingSource;
            this.listview.DoubleBuffered = true;
            this.listview.EnableHeadersVisualStyles = false;
            this.listview.HeaderBgColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.listview.HeaderForeColor = System.Drawing.Color.White;
            this.listview.Location = new System.Drawing.Point (42, 157);
            this.listview.Name = "listview";
            this.listview.ReadOnly = true;
            this.listview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listview.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.listview.RowTemplate.Height = 25;
            this.listview.RowTemplate.ReadOnly = true;
            this.listview.Size = new System.Drawing.Size (1148, 498);
            this.listview.TabIndex = 26;
            this.ID.DataPropertyName = "ComplainID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.complainBindingSource.DataSource = typeof (Northwind.Common.Model.Complain);
            this.bunifuDropdown1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font ("Calibri", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items.AddRange (new object[]
                {"CDS", "CST", "COE", "Medical Center", "Health Center", "Senate", "Hostel", "Others"});
            this.bunifuDropdown1.Location = new System.Drawing.Point (769, 82);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size (200, 32);
            this.bunifuDropdown1.TabIndex = 27;
            this.bunifuDropdown1.Text = null;
            this.bunifuDropdown1.SelectedIndexChanged +=
                new System.EventHandler (this.BunifuDropdown1_SelectedIndexChanged);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Calibri", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (0)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.label2.Location = new System.Drawing.Point (995, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (107, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Filter Type:";
            this.AutoScaleDimensions = new System.Drawing.SizeF (7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1233, 787);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.bunifuDropdown1);
            this.Controls.Add (this.listview);
            this.Controls.Add (this.bunifuImageButton1);
            this.Controls.Add (this.dropdownFilter);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.label11);
            this.Controls.Add (this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
            this.Name = "ComplaintsList";
            this.Text = "ComplaintsList";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler (this.Key_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler (this.Key_Up);
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton1)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.listview)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.complainBindingSource)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownFilter;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid listview;
        private System.Windows.Forms.BindingSource complainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
    }
}