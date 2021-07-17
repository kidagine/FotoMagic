using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fotomagic
{
	/// <summary>
	/// Interaction logic for SplashScreen.xaml
	/// </summary>
	public partial class SplashScreen : Window
	{
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();


        public SplashScreen()
        {
            InitializeComponent();
            StartAnimation();

            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
        }
        public void StartAnimation()
        {
            imgSplashScreen.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation(1, TimeSpan.FromSeconds(1f));
            imgSplashScreen.BeginAnimation(ImageBrush.OpacityProperty, animation);
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            ProductsScreen productsScreen = new ProductsScreen();
            this.Hide();
            productsScreen.Show();

            dispatcherTimer.Stop();
		}
    }
}