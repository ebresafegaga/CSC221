using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.Helpers
{
    public static class FormHelpers
    {
        public static void NavigateTo<T>(this Form form) where T : Form
        {
            var des = Activator.CreateInstance<T>() as Form;
            des.TopLevel = false;
            form.Controls.Clear();
            form.Controls.Add(des);
            des.Show();
        }
    }
}
