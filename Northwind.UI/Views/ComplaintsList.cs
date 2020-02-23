using Bunifu.UI.WinForms;
using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.Views
{
    public partial class ComplaintsList : Form
    {
        public Common.Model.FacilityManager User { get; set; }
        
        private List<string> _filters = new List<string> ();
        private string f1 = "";
        private string f2 = "";
        
        public ComplaintsList()
        {
            InitializeComponent();
        }

        public ComplaintsList(Common.Model.FacilityManager user)
        {
            InitializeComponent();
            User = user;
            using (NorthwindContext context = new NorthwindContext())
            {
                listview.DataSource = context.Complains.Include("User").ToList();
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

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            // Go to facility page and pass tag around
            FacilityManager form = new FacilityManager(User);
            form.Show();
            _filters.Clear ();
            Hide();
        }
        
        private void DropdownFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = dropdownFilter.SelectedItem.ToString();
            f1 = filter;
            _filters.Add (filter);
            
            using (NorthwindContext context = new NorthwindContext())
            {
                // Beware of client side evaluation in the case of a very large data set!
                if (!string.IsNullOrEmpty (f2))
                    listview.DataSource = context.Complains.Include("User")
                        .Where (c => f1 == c.Status.ToString() && f2 == c.Location.ToString())
                        .ToList ();
                else 
                    listview.DataSource = context.Complains.Include("User")
                        .Where (c => f1 == c.Status.ToString())
                        .ToList ();
            }
        }

        private void BunifuDropdown1_SelectedIndexChanged (object sender, EventArgs e)
        {
            var filter = bunifuDropdown1.SelectedItem.ToString();
            f2 = filter;
            _filters.Add (filter);
            using (NorthwindContext context = new NorthwindContext())
            {
                // Beware of client side evaluation in the case of a very large data set!
                if (!string.IsNullOrEmpty (f1))
                    listview.DataSource = context.Complains.Include("User")
                        .Where (c => f1 == c.Status.ToString() && f2 == c.Location.ToString())
                        .ToList ();
                else 
                    listview.DataSource = context.Complains.Include("User")
                        .Where (c => f2 == c.Location.ToString())
                        .ToList ();
            }
        }

        // TODO: To refresh lists.
        private void Key_Up (object sender, KeyEventArgs e)
        {
            Debug.WriteLine ("Entered key up");
            if (e.Control && (e.KeyData & Keys.R) == Keys.R)
            {
                Debug.WriteLine ("Called Key UP");
                _filters.Clear ();
                bunifuDropdown1.SelectedItem = " ";
                dropdownFilter.SelectedItem = " ";
                BunifuDropdown1_SelectedIndexChanged (null, null);
                DropdownFilter_SelectedIndexChanged (null, null);
            }
        }

        private void Key_Down (object sender, KeyEventArgs e)
        {
            Debug.WriteLine ("Enteredd key down");
            if (e.Control && (e.KeyData & Keys.R) == Keys.R)
            {
                Debug.WriteLine ("Called Key down");
                _filters.Clear ();
                bunifuDropdown1.SelectedItem = " ";
                dropdownFilter.SelectedItem = " ";
                BunifuDropdown1_SelectedIndexChanged (null, null);
                DropdownFilter_SelectedIndexChanged (null, null);
            }
        }
    }
}
