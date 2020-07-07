using Pizzeria.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pizzeria.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        public CustomerView(string username)
        {
            InitializeComponent();
            this.DataContext = new CustomerViewModel(this,username);            
        }

        /// <summary>
        /// method for the textbox validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// methods for calculating the total price amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSmall(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(small.Text) && !string.IsNullOrEmpty(medium.Text) && !string.IsNullOrEmpty(big.Text) && !string.IsNullOrEmpty(jumbo.Text))
            {
                total.Text = (Convert.ToInt32(small.Text) * 350 + Convert.ToInt32(medium.Text) * 500 + Convert.ToInt32(big.Text) * 700 + Convert.ToInt32(jumbo.Text) * 900).ToString();
            }
        }

        private void tbMedium(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(small.Text) && !string.IsNullOrEmpty(medium.Text) && !string.IsNullOrEmpty(big.Text) && !string.IsNullOrEmpty(jumbo.Text))
            {
                total.Text = (Convert.ToInt32(small.Text) * 350 + Convert.ToInt32(medium.Text) * 500 + Convert.ToInt32(big.Text) * 700 + Convert.ToInt32(jumbo.Text) * 900).ToString();
            }
        }

        private void tbBig(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(small.Text) && !string.IsNullOrEmpty(medium.Text) && !string.IsNullOrEmpty(big.Text) && !string.IsNullOrEmpty(jumbo.Text))
            {
                total.Text = (Convert.ToInt32(small.Text) * 350 + Convert.ToInt32(medium.Text) * 500 + Convert.ToInt32(big.Text) * 700 + Convert.ToInt32(jumbo.Text) * 900).ToString();
            }
        }

        private void tbJumbo(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(small.Text) && !string.IsNullOrEmpty(medium.Text) && !string.IsNullOrEmpty(big.Text) && !string.IsNullOrEmpty(jumbo.Text))
            {
                total.Text = (Convert.ToInt32(small.Text) * 350 + Convert.ToInt32(medium.Text) * 500 + Convert.ToInt32(big.Text) * 700 + Convert.ToInt32(jumbo.Text) * 900).ToString();
            }
        }

        private void tbTotal(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(small.Text) && !string.IsNullOrEmpty(medium.Text) && !string.IsNullOrEmpty(big.Text) && !string.IsNullOrEmpty(jumbo.Text))
            {
                total.Text = (Convert.ToInt32(small.Text) * 350 + Convert.ToInt32(medium.Text) * 500 + Convert.ToInt32(big.Text) * 700 + Convert.ToInt32(jumbo.Text) * 900).ToString();
            }
        }
    }
}
