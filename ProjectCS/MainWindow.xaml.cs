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
            if (Class2.foods.Any(x => x.Name == (string)foodComboBox.SelectedItem))
            {

                var price = Class2.foods.Find(x => x.Name == (string)foodComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Class2.foods.Find(x => x.Name == (string)foodComboBox.SelectedItem));

                    SalesTax(price);

                    foodComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Class2.foods.Find(x => x.Name == (string)foodComboBox.SelectedItem));

                    SalesTax(price);

                    foodComboBox.SelectedIndex = -1;
                }
            }
        }

        private void billsSelect(object sender, SelectionChangedEventArgs b)
        {
            if (Class2.bills.Any(x => x.Name == (string)billsComboBox.SelectedItem))
            {

                var price = Class2.bills.Find(x => x.Name == (string)billsComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Class2.bills.Find(x => x.Name == (string)foodComboBox.SelectedItem));

                    SalesTax(price);

                    billsComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Class2.bills.Find(x => x.Name == (string)billsComboBox.SelectedItem));

                    SalesTax(price);

                    billsComboBox.SelectedIndex = -1;
                }
            }
        }

        private void subsSelect(object sender, SelectionChangedEventArgs b)
        {
            if (Class2.subs.Any(x => x.Name == (string)subsComboBox.SelectedItem))
            {

                var price = Class2.subs.Find(x => x.Name == (string)subsComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Class2.subs.Find(x => x.Name == (string)subsComboBox.SelectedItem));

                    SalesTax(price);

                    subsComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Class2.subs.Find(x => x.Name == (string)subsComboBox.SelectedItem));

                    SalesTax(price);

                    subsComboBox.SelectedIndex = -1;
                }
            }
        }

        private void outingsSelect(object sender, SelectionChangedEventArgs b)
        {
            if (Class2.outings.Any(x => x.Name == (string)outingsComboBox.SelectedItem))
            {

                var price = Class2.outings.Find(x => x.Name == (string)outingsComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Class2.outings.Find(x => x.Name == (string)outingsComboBox.SelectedItem));

                    SalesTax(price);

                    outingsComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Class2.outings.Find(x => x.Name == (string)outingsComboBox.SelectedItem));

                    SalesTax(price);

                    outingsComboBox.SelectedIndex = -1;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Class2.foods)
            {
                foodComboBox.Items.Add(item.Name);
            }

            foreach (var item in Class2.bills)
            {
                billsComboBox.Items.Add(item.Name);
            }

            foreach (var item in Class2.subs)
            {
                subsComboBox.Items.Add(item.Name);
            }

            foreach (var item in Class2.outings)
            {
                outingsComboBox.Items.Add(item.Name);
            }
        }



        private void SalesTax(Class1 Price)
        {
            decimal tax = 0.6M;
            var salesTax = Price.Price * tax;
            salesTax = Math.Round(salesTax, 1);
            if (salesTax < 0.1M)
            {
                salesTax = 0.1M;
            }

            Tax += salesTax;
            taxBlock.Text = Tax.ToString("C2");

            CalculateTotal(Price, salesTax);
        }
        private void CalculateTotal(Class1 Price, decimal salesTax)
        {
            var total = Price.Price + salesTax;
            Total += total;
            totalTextBlock.Text = Total.ToString("C2");
        }
    }
}
