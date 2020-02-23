using Northwind.Common.Model;
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
    public partial class ComplainDetails : Form
    {
        public Complain Complain { get; set; }
        public bool IsManager { get; set; }

        public ComplainDetails()
        {
            InitializeComponent();
        }

        public ComplainDetails(int key, Complain complain, bool isManager)
        {
            InitializeComponent();
            this.Complain = complain;
            this.IsManager = isManager;
        }
    }
}
