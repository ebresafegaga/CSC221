using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void OnSplashScreenLoaded(object sender, EventArgs e)
        {
            
        }

        private async void OnActivatedAsync(object sender, EventArgs e)
        {
            await Task.Delay(3000);

            // TODO: open home page.
            Application.Exit();
        }
    }
}
