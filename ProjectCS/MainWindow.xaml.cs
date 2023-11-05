using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
        private static void RemoveQuantity()
        {
            foreach (var item in Class2.foods)
            {
                item.Quantity = 1;
            }

            foreach (var item in Class2.bills)
            {
                item.Quantity = 1;
            }

            foreach (var item in Class2.subs)
            {
                item.Quantity = 1;
            }

            foreach (var item in Class2.outings)
            {
                item.Quantity = 1;
            }
        }
            private void clearButton_Click(object sender, RoutedEventArgs e)
            {
                itemsDataGrid.Items.Clear();
                Total = 0.00M;
                Tax = 0.00M;
                taxBlock.Text = "$0.00";
                totalTextBlock.Text = "$0.00";

                RemoveQuantity();
            }
        // tramsform into PDF
        /*private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in itemsDataGrid.Items)
            {
                Class2 i = item as Class2;
                cart.Add(i);
            }

            var doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            var pdf = PdfWriter.GetInstance(doc, new FileStream("order.pdf", FileMode.OpenOrCreate));
            doc.Open();

            iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 30, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font myFont1 = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);

            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Your orders:", myFont);

            doc.Add(p);
            doc.Add(new iTextSharp.text.Paragraph(" "));
            doc.Add(new iTextSharp.text.Paragraph(" "));

            doc.Add(new iTextSharp.text.Paragraph($"Name                  Price            Quantitiy", myFont1));
            foreach (var item in cart)
            {
                doc.Add(new iTextSharp.text.Paragraph($"{item.Name}                        {item.Price:C}                                   {item.Quantity}"));
            }

            doc.Add(new iTextSharp.text.Paragraph(" "));
            doc.Add(new iTextSharp.text.Paragraph(" "));

            doc.Add(new iTextSharp.text.Paragraph($"The total of your order: {Total:C}", myFont1));
            doc.Close();

            System.Diagnostics.Process.Start("order.pdf");

            itemsDataGrid.Items.Clear();
            Total = 0.00M;
            Tax = 0.00M;
            taxBlock.Text = "$0.00";
            totalTextBlock.Text = "$0.00";

            RemoveQuantity();
        }*/
    }
}
