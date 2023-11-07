using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
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

        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";


        public MainWindow()
        {
            InitializeComponent();
            GoogleAPI();
        }


        private void GoogleAPI()
        {

            UserCredential credential;
            // Load client secrets.
            using (var stream =
                   new FileStream("client_secret_372547293794-lgmqp7khkv2bk9rdupedtqkc3sq6rk0m.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                /* The file token.json stores the user's access and refresh tokens, and is created
                 automatically when the authorization flow completes for the first time. */
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            if (events.Items == null || events.Items.Count == 0)
            {
                CalendarEvents.Content = "";
                foreach (var eventItem in events.Items)
                {
                    CalendarEvents.Content += eventItem.Summary + Environment.NewLine;
                }

            }

            else
            {
                CalendarEvents.Content = "No financial events";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            GoogleAPI();
        }

        


        // SelectionChangedEventArgs here
        private void foodComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void billsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs b)
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

        private void subsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs b)
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

        private void outingsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs b)
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
