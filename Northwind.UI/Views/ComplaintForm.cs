using Northwind.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Northwind.UI.Views
{
    public partial class ComplaintForm : Form
    {
        public Common.Model.MainUser User { get; set; }
        public ComplaintForm()
        {
            InitializeComponent();
            complaintSubmitedPanel.Visible = false;
            lblError.Visible = false;
            dropdownLocaton.Text = "CDS";
            dropdownType.Text = "Electrical";
            dropdownStatus.Text = "Pending";
        }
        public ComplaintForm(Common.Model.MainUser user)
        {
            User = user;
            InitializeComponent();
            complaintSubmitedPanel.Visible = false;
            lblError.Visible = false;
            dropdownLocaton.Text = "CDS";
            dropdownType.Text = "Electrical";
            dropdownStatus.Text = "Pending";
        }

        #region Close
        private void OnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void OnHoverLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.FromArgb(0, 64, 64);
        }
        #endregion

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                // Get data and send to Db.
                var complain = new Common.Model.Complain
                {
                    Description = txtDescription.Text,
                    Type = (Common.ComplainType)Enum.Parse(typeof(Common.ComplainType), dropdownType.Text),
                    Location = (Common.Location)Enum.Parse(typeof(Common.Location), dropdownLocaton.Text),
                    Status = (Common.ComplainStatus)Enum.Parse(typeof(Common.ComplainStatus), dropdownStatus.Text),
                    Time = datepickerDate.Value
                };

                using (NorthwindContext context = new NorthwindContext())
                {
                    var user = context.Users.Include("Complains").Where(u => u.UserName == User.UserName).ToList()[0];
                    user.Complains.Add(complain);
                    context.SaveChanges();
                }

                // navigate to new page.
                Timer timer = new Timer
                {
                    Interval = 3800,
                    Enabled = true
                };
                timer.Tick += (obj, args) =>
                {
                    timer.Enabled = false;
                    MainUser form = new MainUser(User);
                    form.Show();
                    Hide();
                };
                complaintSubmitedPanel.Visible = true;
                timer.Start();
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            MainUser form = new MainUser(User);
            form.Tag = User;
            form.Show();
            this.Hide();
        }
    }
}
