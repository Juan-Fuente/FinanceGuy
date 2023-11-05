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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectCS
{

    public partial class MainWindow : Window
    {
        public static List<Class1> cart = new List<Class1>();

        private decimal Total { get; set; }
        private decimal Tax { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }


        // SelectionChangedEventArgs here

        private void foodSelect(object sender, SelectionChangedEventArgs b)
        {
            if (Class2.bills.Any(x => x.Name == (string)billsComboBox.SelectedItem))
            {

                var price = Class2.foods.Find(x => x.Name == (string)billsComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Class2.foods.Find(x => x.Name == (string)billsComboBox.SelectedItem));

                    SalesTax(price);

                    billsComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Class2.foods.Find(x => x.Name == (string)billsComboBox.SelectedItem));

                    SalesTax(price);

                    billsComboBox.SelectedIndex = -1;
                }
            }
        }

        private void SalesTax(Class1 price)
        {
            decimal tax = 0.6M;
            var salesTax = price.Price * tax;
            salesTax = Math.Round(salesTax, 1);
            if (salesTax < 0.1M)
            {
                salesTax = 0.1M;
            }

            Tax += salesTax;
            taxBlock.Text = Tax.ToString("C2");

            CalculateTotal(price, salesTax);
        }
        private void CalculateTotal(Class1 price, decimal salesTax)
        {
            var total = price.Price + salesTax;
            Total += total;
            totalTextBlock.Text = Total.ToString("C2");
        }

    }
        
        
        /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
