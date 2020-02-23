namespace Northwind.UI.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblH2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordCheck = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.dropUserType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblBadlogin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dropdownLogin = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.loginID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblErrorSignup = new System.Windows.Forms.Label();
            this.signupProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Location = new System.Drawing.Point(966, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.OnClose);
            this.lblClose.MouseEnter += new System.EventHandler(this.OnHover);
            this.lblClose.MouseLeave += new System.EventHandler(this.OnHoverLeave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(260, 39);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Northwind Traders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblH2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 721);
            this.panel1.TabIndex = 2;
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.BackColor = System.Drawing.Color.Transparent;
            this.lblH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH2.ForeColor = System.Drawing.Color.White;
            this.lblH2.Location = new System.Drawing.Point(119, 357);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(171, 32);
            this.lblH2.TabIndex = 3;
            this.lblH2.Text = "File a complain, We listen, \r\n     We Repair, We maintain.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(473, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sign Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(473, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.LineThickness = 4;
            this.txtUserName.Location = new System.Drawing.Point(480, 141);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(409, 33);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(475, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(480, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(409, 33);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(475, 307);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 29);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(480, 356);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 33);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(475, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Re-Enter Password:";
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPasswordCheck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPasswordCheck.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPasswordCheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordCheck.HintForeColor = System.Drawing.Color.Empty;
            this.txtPasswordCheck.HintText = "";
            this.txtPasswordCheck.isPassword = true;
            this.txtPasswordCheck.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordCheck.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordCheck.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordCheck.LineThickness = 4;
            this.txtPasswordCheck.Location = new System.Drawing.Point(480, 452);
            this.txtPasswordCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordCheck.MaxLength = 32767;
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.Size = new System.Drawing.Size(409, 33);
            this.txtPasswordCheck.TabIndex = 12;
            this.txtPasswordCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(475, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Type:";
            // 
            // dropUserType
            // 
            this.dropUserType.BackColor = System.Drawing.Color.White;
            this.dropUserType.BorderRadius = 1;
            this.dropUserType.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropUserType.DisabledColor = System.Drawing.Color.Gray;
            this.dropUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropUserType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropUserType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropUserType.FillDropDown = false;
            this.dropUserType.FillIndicator = false;
            this.dropUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropUserType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.FormattingEnabled = true;
            this.dropUserType.Icon = null;
            this.dropUserType.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropUserType.ItemBackColor = System.Drawing.Color.White;
            this.dropUserType.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.ItemHeight = 26;
            this.dropUserType.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropUserType.Items.AddRange(new object[] {
            "Main User",
            "Facility Manager"});
            this.dropUserType.Location = new System.Drawing.Point(596, 513);
            this.dropUserType.Name = "dropUserType";
            this.dropUserType.Size = new System.Drawing.Size(293, 32);
            this.dropUserType.TabIndex = 14;
            this.dropUserType.Text = null;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Sign Up";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(478, 617);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(409, 42);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Sign Up";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(476, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Already have an account? LOG IN.";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Teal;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(494, 567);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(520, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "I Agree to Terms and Conditions";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginProgress);
            this.panel2.Controls.Add(this.lblBadlogin);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dropdownLogin);
            this.panel2.Controls.Add(this.lblErrorLogin);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.loginPass);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.loginID);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(473, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 664);
            this.panel2.TabIndex = 4;
            // 
            // loginProgress
            // 
            this.loginProgress.animated = false;
            this.loginProgress.animationIterval = 5;
            this.loginProgress.animationSpeed = 300;
            this.loginProgress.BackColor = System.Drawing.Color.White;
            this.loginProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginProgress.BackgroundImage")));
            this.loginProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.loginProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginProgress.LabelVisible = true;
            this.loginProgress.LineProgressThickness = 8;
            this.loginProgress.LineThickness = 5;
            this.loginProgress.Location = new System.Drawing.Point(412, 21);
            this.loginProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.loginProgress.MaxValue = 100;
            this.loginProgress.Name = "loginProgress";
            this.loginProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loginProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginProgress.Size = new System.Drawing.Size(98, 98);
            this.loginProgress.TabIndex = 4;
            this.loginProgress.Value = 0;
            // 
            // lblBadlogin
            // 
            this.lblBadlogin.AutoSize = true;
            this.lblBadlogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadlogin.ForeColor = System.Drawing.Color.Red;
            this.lblBadlogin.Location = new System.Drawing.Point(22, 559);
            this.lblBadlogin.Name = "lblBadlogin";
            this.lblBadlogin.Size = new System.Drawing.Size(315, 18);
            this.lblBadlogin.TabIndex = 24;
            this.lblBadlogin.Text = "Email is not valid or your password doesn\'t match.\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(28, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 39);
            this.label14.TabIndex = 23;
            this.label14.Text = "Type:";
            // 
            // dropdownLogin
            // 
            this.dropdownLogin.BackColor = System.Drawing.Color.White;
            this.dropdownLogin.BorderRadius = 1;
            this.dropdownLogin.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownLogin.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownLogin.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropdownLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownLogin.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownLogin.FillDropDown = false;
            this.dropdownLogin.FillIndicator = false;
            this.dropdownLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.FormattingEnabled = true;
            this.dropdownLogin.Icon = null;
            this.dropdownLogin.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownLogin.ItemBackColor = System.Drawing.Color.White;
            this.dropdownLogin.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.ItemHeight = 26;
            this.dropdownLogin.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropdownLogin.Items.AddRange(new object[] {
            "Main User",
            "Facility Manager"});
            this.dropdownLogin.Location = new System.Drawing.Point(123, 274);
            this.dropdownLogin.Name = "dropdownLogin";
            this.dropdownLogin.Size = new System.Drawing.Size(293, 32);
            this.dropdownLogin.TabIndex = 22;
            this.dropdownLogin.Text = null;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLogin.Location = new System.Drawing.Point(25, 51);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(255, 18);
            this.lblErrorLogin.TabIndex = 21;
            this.lblErrorLogin.Text = "Please enter a valid email and password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(21, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "Don\'t have an account? SIGN UP.\r\n";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Log In as the Management";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(21, 440);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(409, 42);
            this.bunifuFlatButton3.TabIndex = 18;
            this.bunifuFlatButton3.Text = "Log In as the Management";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(209, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 39);
            this.label12.TabIndex = 17;
            this.label12.Text = "Or";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Log In";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(25, 319);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(409, 42);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "Log In";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // loginPass
            // 
            this.loginPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPass.HintForeColor = System.Drawing.Color.Empty;
            this.loginPass.HintText = "";
            this.loginPass.isPassword = true;
            this.loginPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPass.LineThickness = 4;
            this.loginPass.Location = new System.Drawing.Point(21, 216);
            this.loginPass.Margin = new System.Windows.Forms.Padding(4);
            this.loginPass.MaxLength = 32767;
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(409, 38);
            this.loginPass.TabIndex = 9;
            this.loginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(18, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 39);
            this.label11.TabIndex = 8;
            this.label11.Text = "Password:";
            // 
            // loginID
            // 
            this.loginID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginID.HintForeColor = System.Drawing.Color.Empty;
            this.loginID.HintText = "";
            this.loginID.isPassword = false;
            this.loginID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginID.LineThickness = 4;
            this.loginID.Location = new System.Drawing.Point(21, 123);
            this.loginID.Margin = new System.Windows.Forms.Padding(4);
            this.loginID.MaxLength = 32767;
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(409, 33);
            this.loginID.TabIndex = 7;
            this.loginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(18, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 39);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email or Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(18, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 39);
            this.label9.TabIndex = 5;
            this.label9.Text = "Log In";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblErrorSignup
            // 
            this.lblErrorSignup.AutoSize = true;
            this.lblErrorSignup.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSignup.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSignup.Location = new System.Drawing.Point(477, 80);
            this.lblErrorSignup.Name = "lblErrorSignup";
            this.lblErrorSignup.Size = new System.Drawing.Size(315, 18);
            this.lblErrorSignup.TabIndex = 22;
            this.lblErrorSignup.Text = "Email is not valid or your password doesn\'t match.\r\n";
            // 
            // signupProgress
            // 
            this.signupProgress.animated = false;
            this.signupProgress.animationIterval = 5;
            this.signupProgress.animationSpeed = 300;
            this.signupProgress.BackColor = System.Drawing.Color.White;
            this.signupProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupProgress.BackgroundImage")));
            this.signupProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.signupProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupProgress.LabelVisible = true;
            this.signupProgress.LineProgressThickness = 8;
            this.signupProgress.LineThickness = 5;
            this.signupProgress.Location = new System.Drawing.Point(867, 39);
            this.signupProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.signupProgress.MaxValue = 100;
            this.signupProgress.Name = "signupProgress";
            this.signupProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.signupProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupProgress.Size = new System.Drawing.Size(98, 98);
            this.signupProgress.TabIndex = 23;
            this.signupProgress.Value = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 721);
            this.Controls.Add(this.signupProgress);
            this.Controls.Add(this.lblErrorSignup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.dropUserType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.OnHomeLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordCheck;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown dropUserType;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        public System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginPass;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label lblErrorSignup;
        private System.Windows.Forms.Label label14;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownLogin;
        private System.Windows.Forms.Label lblBadlogin;
        private Bunifu.Framework.UI.BunifuCircleProgressbar loginProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar signupProgress;
    }
}