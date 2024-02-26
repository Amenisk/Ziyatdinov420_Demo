using LopushokApp.ADO;
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

namespace LopushokApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {
        int lastPage = 0;
        public ProductList()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            for(int i = 1; i < App.Connection.Product.ToList().Count() / 20; i++)
            {
                names.Add(i.ToString());
                lastPage = i;
            }

            if(App.Connection.Product.ToList().Count() % 20 != 0)
            {
                lastPage++;
                names.Add(lastPage.ToString());
            }

            lvPages.ItemsSource = names;
            lvPages.SelectedIndex = 0;
            lvProducts.ItemsSource = App.Connection.Product.ToList().Take(20);
        }

        private void MinusPage(object sender, RoutedEventArgs e)
        {
            if(lvPages.SelectedIndex != 0)
            {
                lvPages.SelectedIndex = --lvPages.SelectedIndex;
                lvProducts.ItemsSource = App.Connection.Product.ToList().Skip(lvPages.SelectedIndex * 20).Take(20);
            }
        }

        private void PlusPage(object sender, RoutedEventArgs e)
        {
            if (lvPages.SelectedIndex != lastPage - 1)
            {
                lvPages.SelectedIndex = ++lvPages.SelectedIndex;
                lvProducts.ItemsSource = App.Connection.Product.ToList().Skip(lvPages.SelectedIndex * 20).Take(20);
            }
        }
    }
}
