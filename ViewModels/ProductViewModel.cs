namespace ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    public class ProductViewModel:INotifyPropertyChanged
    {
        #region Attributes
        private int productId;
        private string productName;
        private decimal unitPrice;
        private int unitInStock;
        private int categoryId;
        private string messsage;
        #endregion

        #region Properties
        public int ProductId
        {
            get => productId;
            set
            {
                if (productId != value)
                {
                    productId = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string ProductName
        {
            get => productName;
            set
            {
                if (productName != value)
                {
                    productName = value;
                    NotifyPropertyChanged();
                }
            }
        } 
        public decimal UnitPrice
        {
            get => unitPrice;
            set
            {
                if (unitPrice != value)
                {
                    unitPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int UnitInStock
        {
            get => unitInStock;
            set
            {
                if (unitInStock != value)
                {
                    unitInStock = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int CategoryId
        {
            get => categoryId;
            set
            {
                if (categoryId!= value)
                {
                    categoryId = value;
                    NotifyPropertyChanged();
                }
            }
        }     
        public string Message
        {
            get => messsage;
            set
            {
                if (messsage != value)
                {
                    messsage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Constructs
        public ProductViewModel()
        {
           
        }

        


        #endregion

        #region Commands

        #endregion

        #region Methods
        public void GetProductById(int Id)
        {
            if (Id > 0)
            {
                var bll = new BLL.Product();
                bll.errorEvent += (s, ev) => Message = ev.Message;
                Entities.Product product = bll.GetProductById(Id);

                if (product == null)
                {
                    Message = $"No exite el registo con el Id: {Id}";
                    
                }
                else
                {
                    ProductId = product.ProductId;
                    ProductName = product.ProductName;
                    UnitPrice = product.UnitPrice;
                    UnitInStock = product.UnitInStock;
                    CategoryId = product.CategoryId;
                }

               
            }
            else
            {
                Message = "Ingrese un numero mayor que cero";

                ProductId = 0;
                ProductName = string.Empty;
                UnitPrice = 0;
                UnitInStock = 0;
                CategoryId = 0;
            }
          

           

        }
        #endregion


        
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
