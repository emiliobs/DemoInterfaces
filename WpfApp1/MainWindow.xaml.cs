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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //BLL.Product B;
        public MainWindow()
        {
            InitializeComponent();                         
            //B = new BLL.Product();
            txtSearchProduct.Text = string.Empty;

            btnSearch.Click += BtnSearch_Click;

            //var c = ViewModels.Class1.CreateInstance();
             
            

        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
           var vm =  this.DataContext as ViewModels.ProductViewModel;
            vm.GetProductById(Convert.ToInt32(txtSearchProduct.Text));
            DataContext = vm;
        }

        //private void BtnSearch_Click(object sender, RoutedEventArgs e)
        //{
        //    var B = new BLL.Product();

        //    //Aqui invo el el evento que contiene el delagado del la clase en BLL
        //    B.errorEvent += (s, ev) => txtMessage.Text = ev.Message;

        //    var product = new Entities.Product();

        //    if (!string.IsNullOrEmpty(txtSearchProduct.Text))
        //    {
        //          product = B.GetProductById(int.Parse(txtSearchProduct.Text));
        //    }
        //    else      
        //    {
        //        MessageBox.Show("Ingrese un Product Id.");
        //        return;
        //    }



        //    if (product != null)
        //    {


        //        txtProductId.Text = product.ProductId.ToString();
        //        txtName.Text = product.ProductName;
        //        txtUnitPrice.Text = product.UnitPrice.ToString();
        //        txtUnitStock.Text = product.UnitInStock.ToString();
        //        txtCAtegoryId.Text = product.CategoryId.ToString();

        //    }

        //}



        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtSearchProduct.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitStock.Text = string.Empty;
            txtCAtegoryId.Text = string.Empty;
            txtMessage.Text = string.Empty;
        }
    }
}
