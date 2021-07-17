using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fotomagic
{
	/// <summary>
	/// Interaction logic for ProductsScreen.xaml
	/// </summary>
	public partial class ProductsScreen : Window
	{
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

		public ProductsScreen()
		{
			InitializeComponent();
		}
		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RctDarken_MouseDown(object sender, MouseButtonEventArgs e)
		{

		}

		private void BtnRemove_Click(object sender, RoutedEventArgs e)
		{

		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

        private void TxtSearch_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxtSearch_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void LstCustomers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
