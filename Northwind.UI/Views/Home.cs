using Bunifu.Framework.UI;
using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.Views
{
    // TODO: make login asynchronous and show a good indicator!

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            dropUserType.Text = "Main User";
            dropdownLogin.Text = "Main User";
            panel2.Visible = false;
            //panel3.Visible = false;
            this.lblErrorLogin.Visible = false;
            this.lblErrorSignup.Visible = false;
            this.lblBadlogin.Visible = false;
            this.loginProgress.Visible = false;
            this.signupProgress.Visible = false;
        }

        private void OnClose(object sender, EventArgs e)
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

        private void OnHomeLoad(object sender, EventArgs e)
        {
            // ...
        }

        private async void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // Sign up
            if (this.dropUserType.Text == "Main User")
            {
                Common.Model.MainUser user = new Common.Model.MainUser
                {
                    Email = txtEmail.Text.Trim().ToLower(),
                    UserName = txtUserName.Text.Trim().ToLower(),
                    Password = txtPassword.Text.Trim().GetHashCode(),
                    PasswordCheck = txtPasswordCheck.Text.Trim().GetHashCode()
                };

                if (user.Validate())
                {
                    // valid details
                    Console.WriteLine("Valid");
                    this.lblErrorSignup.Visible = false;

                    var btn = sender as BunifuFlatButton;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    label5.Enabled = false;

                    //signupProgress.Visible = true;
                    //Timer t = new Timer
                    //{
                    //    Interval = 10,
                    //    Enabled = true
                    //};
                    
                    //t.Tick += (obj, args) =>
                    //{
                    //    if (signupProgress.Value <= 99)
                    //    {
                    //        signupProgress.Value += 1;
                    //    }
                    //    else
                    //    {
                    //        t.Enabled = false;
                    //    }
                    //};
                    //t.Start();
                    

                    // Add user to  DB and log in
                    using (NorthwindContext context = new NorthwindContext())
                    {
                        await Task.Factory.StartNew(() => context.Users.Add(user));
                        //Task task = new Task(() => context.Users.Add(user));
                        await context.SaveChangesAsync();
                    }
                    // pass data to MainUser
                    MainUser form = new MainUser(user);
                    form.Show();
                    Hide();
                }
                else
                {
                    // invalid
                    Console.WriteLine("Invalid");
                    this.lblErrorSignup.Visible = true;
                }
            }
            if (this.dropUserType.Text == "Facility Manager")
            {
                Common.Model.FacilityManager user = new Common.Model.FacilityManager
                {
                    Email = txtEmail.Text.Trim().ToLower(),
                    UserName = txtUserName.Text.Trim().ToLower(),
                    Password = txtPassword.Text.Trim().GetHashCode(),
                    PasswordCheck = txtPasswordCheck.Text.Trim().GetHashCode()
                };

                if (user.Validate())
                {


                    // valid
                    Console.WriteLine("Valid");
                    this.lblErrorSignup.Visible = false;

                    var btn = sender as BunifuFlatButton;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    label5.Enabled = false;

                    // Log user in
                    using (NorthwindContext context = new NorthwindContext())
                    {
                        // TODO: show a loading page
                        await Task.Factory.StartNew(() => context.Managers.Add(user));
                        await context.SaveChangesAsync();
                    }

                    // pass data
                    FacilityManager form = new FacilityManager(user);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // invalid

                    Console.WriteLine("Invalid");
                    this.lblErrorSignup.Visible = true;
                }
            }
            // TODO: Ask for number if facility manager.
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            // Go to login page
            this.txtEmail.Text = 
                this.txtUserName.Text = 
                this.txtPassword.Text = 
                this.txtPasswordCheck.Text = 
                string.Empty;
            this.lblErrorSignup.Visible = false;

            panel2.Visible = true;
        }

        private async void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Log in
            if (dropdownLogin.Text == "Main User")
            {
                // TODO: Log in user with details from panel 2.
                if (!(string.IsNullOrWhiteSpace(loginID.Text) && string.IsNullOrWhiteSpace(loginPass.Text)))
                {
                    var btn = sender as BunifuFlatButton;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    label3.Enabled = false;

                    var user = new Common.Model.MainUser
                    {
                        UserName = loginID.Text.Trim(),
                        Password = loginPass.Text.GetHashCode()
                    };
                    //Remove error message
                    lblErrorLogin.Visible = false;
                    using (NorthwindContext context = new NorthwindContext())
                    {
                        //List<Common.Model.MainUser> users; 
                        var users = await context.Users.Where(u => u.UserName == user.UserName).ToListAsync();

                        //Task task = new Task(() =>
                        //{
                        //    users = context.Users.Where(u => u.UserName == user.UserName).ToList();
                        //});

                        //var pUsers = from u in context.Users
                        //             where u.UserName == user.UserName
                        //             select u;

                        if (users.Count != 0)
                        {
                            // check password
                            if (user.Password == users.FirstOrDefault().Password)
                            {
                                lblBadlogin.Visible = false;
                                MainUser form = new MainUser(users.ToArray()[0]);
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                // wrong password
                                Console.WriteLine("Wrong password");
                                lblBadlogin.Text = "Wrong password";
                                lblBadlogin.Visible = true;
                                label3.Enabled = true;
                                btn.Enabled = true;
                            }
                        }
                        else
                        {
                            //user not found
                            Console.WriteLine("Invalid user name or password");
                            lblBadlogin.Text = "Invalid Username";
                            lblBadlogin.Visible = true;
                            label3.Enabled = true;
                            btn.Enabled = true;
                        }
                    }
                }
                else
                {
                    //show error message
                    lblErrorLogin.Visible = true;
                }
            }
            else
            {
                // Facility manager log in

                if (!(string.IsNullOrWhiteSpace(loginID.Text) && string.IsNullOrWhiteSpace(loginPass.Text)))
                {
                    var btn = sender as BunifuFlatButton;
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    label3.Enabled = false;

                    var user = new Common.Model.FacilityManager
                    {
                        UserName = loginID.Text.Trim(),
                        Password = loginPass.Text.GetHashCode()
                    };

                    //Remove error message
                    lblErrorLogin.Visible = false;
                    using (NorthwindContext context = new NorthwindContext())
                    {
                        var users = await context.Managers.Where(u => u.UserName == user.UserName).ToListAsync();
                        if (users.Count != 0)
                        {
                            // check password
                            if (user.Password == users.FirstOrDefault().Password)
                            {
                                lblBadlogin.Visible = false;
                                FacilityManager form = new FacilityManager(users.ToArray()[0]);
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                // wrong password
                                Console.WriteLine("Wrong password");
                                lblBadlogin.Text = "Wrong password";
                                lblBadlogin.Visible = true;
                                btn.Enabled = true;
                                label3.Enabled = true;
                            }
                        }
                        else
                        {
                            //user not found
                            Console.WriteLine("Invalid user name or password");
                            lblBadlogin.Text = "Invalid Username";
                            lblBadlogin.Visible = true;
                            btn.Enabled = true;
                            label3.Enabled = true;
                        }
                    }
                }
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // TODO: Management log in

            Management management = new Management();
            management.Show();
            Hide();
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            // Go to sign up page
            loginID.Text = string.Empty;
            loginPass.Text = string.Empty;
            panel2.Visible = false;
        }
    }
}
