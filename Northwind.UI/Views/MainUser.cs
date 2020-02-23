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
    public partial class MainUser : Form
    {
        public Common.Model.MainUser User { get; set; }

        public MainUser()
        {
            InitializeComponent();

            //User = Tag as Common.Model.MainUser;
            if (User != null)
            {
                lblUsername.Text = User.UserName;
                lblEmail.Text = User.Email;
            }

            editProfile.Visible = false;
            //for testing 
            //emptyComplains.Visible = true;
        }
        public MainUser(Common.Model.MainUser user)
        {
            InitializeComponent();
            this.User = user;
            editProfile.Visible = false;
            
            //emptyComplains.Visible = true;
            // Get complaint to show on the list

            using (NorthwindContext context = new NorthwindContext())
            {
                int count = 1;
                var complains = context.Complains.Where(c => c.User.UserName == User.UserName).OrderByDescending(c => c.Time).Take(5);
                var pCount = complains.Count();

                // Remove list items
                switch (pCount)
                {
                    case 0:
                        panel2.Visible = false;
                        label4.Visible = true;
                        //emptyComplains.Visible = true;
                        break;
                    case 1:
                        //emptyComplains.Visible = false;
                        panel2.Visible = true;
                        label4.Visible = false;
                        five.Visible = false;
                        four.Visible = false;
                        three.Visible = false;
                        two.Visible = false;
                        break;
                    case 2:
                        //emptyComplains.Visible = false;
                        panel2.Visible = true;
                        label4.Visible = false;
                        five.Visible = false;
                        four.Visible = false;
                        three.Visible = false;
                        break;
                    case 3:
                        //emptyComplains.Visible = false;
                        label4.Visible = false;
                        panel2.Visible = true;
                        five.Visible = false;
                        four.Visible = false;
                        break;
                    case 4:
                        //emptyComplains.Visible = false;
                        label4.Visible = false;
                        panel2.Visible = true;
                        five.Visible = false;
                        break;
                    case 5:
                        label4.Visible = false;
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
                            break;
                        case 2:
                            twoD.Text = complain.Description;
                            twoStatus.Text = complain.Status.ToString();
                            twoLocation.Text = complain.Location.ToString();
                            twoDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            twoType.Text = complain.Type.ToString();
                            break;
                        case 3:
                            threeD.Text = complain.Description;
                            threeStatus.Text = complain.Status.ToString();
                            threeLocation.Text = complain.Location.ToString();
                            threeDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            threeType.Text = complain.Type.ToString();
                            break;
                        case 4:
                            fourD.Text = complain.Description;
                            fourStatus.Text = complain.Status.ToString();
                            fourLocation.Text = complain.Location.ToString();
                            fourDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            fourType.Text = complain.Type.ToString();
                            break;
                        case 5:
                            fiveD.Text = complain.Description;
                            fiveStatus.Text = complain.Status.ToString();
                            fiveLocation.Text = complain.Location.ToString();
                            fiveDate.Text = complain.Time.ToString("dddd, dd MMMM yyyy");
                            fiveType.Text = complain.Type.ToString();
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
                lblUsername.Text = User.UserName;
                lblEmail.Text = User.Email;

                if (User.Email.Length > 25)
                {
                    nEmail.Text = User.Email.Substring(0, 22) + "...";
                }
                nEmail.Text = User.Email;
            }


            //for testing 
            //emptyComplains.Visible = false;
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

        private void NavigateToAddComplain(object sender, EventArgs e)
        {
            // navigate to add complaints page
            ComplaintForm form = new ComplaintForm(User);
            form.Show();
            this.Hide();
        }

        //TODO: complaint details page
        private void OnClick1(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string name = panel.Name;

            switch (name)
            {
                case "one":
                    //do one.
                    break;
                case "two":
                    // do two.
                    break;
                case "three":
                    // do 3
                    break;
                case "four":
                    // do 5
                    break;
                case "five":
                    // do 5
                    break;
                default:
                    break;
            }
        }

        private void OnEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.FromArgb(0, 45, 45);
        }

        private void OnLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void Label27_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.panel2.Visible = true;
            home.Show();
            this.Hide();
        }

        private void OnH(object sender, EventArgs e)
        {
            Label l = sender as Label;
            Font font = new Font(l.Font, FontStyle.Underline | FontStyle.Bold);
            l.Font = font;
        }

        private void OnHL(object sender, EventArgs e)
        {
            Label l = sender as Label;
            Font font = new Font(l.Font, FontStyle.Regular);
            l.Font = font;
        }

        private void NEmail_Click(object sender, EventArgs e)
        {
            // View profile
        }
    }
}
