using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.Views
{
    public partial class FacilityManager : Form
    {
        public Common.Model.FacilityManager User { get; set; }
        public FacilityManager()
        {
            InitializeComponent();
        }

        public FacilityManager(Common.Model.FacilityManager manager)
        {
            InitializeComponent();
            User = manager;
            using (NorthwindContext context = new NorthwindContext())
            {
                int count = 1;
                var complains = context.Complains.Include("User").OrderByDescending(c => c.Time).Take(5);
                var pCount = complains.Count();
                if (pCount == 0)
                {
                    //emptyComplains.Visible = true;
                }

                // Remove list items
                switch (pCount)
                {
                    case 0:
                        panel2.Visible = false;
                        //label4.Visible = true;
                        //emptyComplains.Visible = true;
                        break;
                    case 1:
                        //emptyComplains.Visible = false;
                        panel2.Visible = true;
                        //label4.Visible = false;
                        five.Visible = false;
                        four.Visible = false;
                        three.Visible = false;
                        two.Visible = false;
                        break;
                    case 2:
                        //emptyComplains.Visible = false;
                        panel2.Visible = true;
                        //label4.Visible = false;
                        five.Visible = false;
                        four.Visible = false;
                        three.Visible = false;
                        break;
                    case 3:
                        //emptyComplains.Visible = false;
                        //label4.Visible = false;
                        panel2.Visible = true;
                        five.Visible = false;
                        four.Visible = false;
                        break;
                    case 4:
                        //emptyComplains.Visible = false;
                        //label4.Visible = false;
                        panel2.Visible = true;
                        five.Visible = false;
                        break;
                    case 5:
                        //label4.Visible = false;
                        panel2.Visible = true;
                        //emptyComplains.Visible = false;
                        // do nothing
                        break;
                    default:
                        break;
                }

                // Add to list view
                foreach (var complain in complains)
                {
                    switch (count)
                    {
                        case 1:
                            oneD.Text = complain.Description;
                            oneStatus.Text = complain.Status.ToString();
                            oneLocation.Text = complain.Location.ToString();
                            oneTime.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            oneType.Text = complain.Type.ToString();
                            oneUser.Text = complain.User.UserName;
                            break;
                        case 2:
                            twoD.Text = complain.Description;
                            twoStatus.Text = complain.Status.ToString();
                            twoLocation.Text = complain.Location.ToString();
                            twoDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            twoType.Text = complain.Type.ToString();
                            twoUser.Text = complain.User.UserName;
                            break;
                        case 3:
                            threeD.Text = complain.Description;
                            threeStatus.Text = complain.Status.ToString();
                            threeLocation.Text = complain.Location.ToString();
                            threeDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            threeType.Text = complain.Type.ToString();
                            threeUser.Text = complain.User.UserName;
                            break;
                        case 4:
                            fourD.Text = complain.Description;
                            fourStatus.Text = complain.Status.ToString();
                            fourLocation.Text = complain.Location.ToString();
                            fourDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            fourType.Text = complain.Type.ToString();
                            fourUser.Text = complain.User.UserName;
                            break;
                        case 5:
                            fiveD.Text = complain.Description;
                            fiveStatus.Text = complain.Status.ToString();
                            fiveLocation.Text = complain.Location.ToString();
                            fiveDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            fiveType.Text = complain.Type.ToString();
                            fiveUser.Text = complain.User.UserName;
                            break;
                        default:
                            // just to make sure.
                            break;
                    }

                    count++;
                }
            }
            if (User != null)
            {
                lblUsername.Text = manager.UserName;
                lblEmail.Text = manager.Email;
            }
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

        private void OnViewAll(object sender, EventArgs e)
        {
            // Navigate to view all user complaints.

            ComplaintsList form = new ComplaintsList(User);
            form.Show();
            this.Hide();
        }

        private void Label27_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.panel2.Visible = true;
            home.Show();
            this.Hide();
        }
    }
}
