using Northwind.Logic;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.UI.Views
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            using (NorthwindContext context = new NorthwindContext())
            {
                complaintsView.DataSource = context.Complains.Include("User").ToList();
                managersView.DataSource = context.Managers.ToList();
            }
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

        private void BunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // location
            var filter = location.SelectedItem.ToString();
            using (NorthwindContext context = new NorthwindContext())
            {
                complaintsView.DataSource = context.Complains
                    .Where(c => c.Location.ToString() == filter)
                    .ToList();
            }
        }

        private void BunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // status
            var filter = status.SelectedItem.ToString();
            using (NorthwindContext context = new NorthwindContext())
            {
                complaintsView.DataSource = context.Complains
                    .Where(c => c.Status.ToString() == filter)
                    .ToList();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.panel2.Visible = true;
            home.Show();
            this.Hide();
        }
    }
}
