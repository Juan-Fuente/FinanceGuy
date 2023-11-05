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

    private void foodSelect(object sender, selectFood f)
{ 
        if (Items.Bills.Any(x => x.Name == (string) mainBillsBox.SelectedItem))
    {

        var price = Items.Bills.Find(x => x.Name == (string)mainBillsBox.SelctedItem);
        var item = itemsDataGrid.Items.IndexOf(price);
        if (item >= 0)
        {
            itemsDataGrid.Items.Remove(price);
            price.Quantity++;
            itemsDataGrid.Items.Add(Items.Bills.Find(x => x.Name == (string) mainCourseComboBox.SelectedItem));
            
            SalesTax(price);

            mainBillsBox.SelectedIndex = -1;
        }
        else
        {
            itemsDataGrid.Items.Add(Items.Bills.Find(x => x.Name == (string));

            SalesTax(price);

            mainBillsBox.SelectedIndex = -1;
        }
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
