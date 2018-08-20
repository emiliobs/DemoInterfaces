namespace BLL
{
    public class Product
    {

        private DALFactory.DALPRodductFactory Factory;

        public Product():this(new DALFactory.DALPRodductFactory())
        {

        }

        public Product(DALFactory.DALPRodductFactory factory)
        {
            Factory = factory;
        }

        public event ErrorEventHandler errorEvent;
        public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);

        public Entities.Product  GetProductById(int Id)
        {
            Entities.Product Result;

            if (Id>0)
            {
                var d = Factory.GetDALProduct();

               //desde e DALFActory que referencia a la Interface de todas la DAL.
                //var factory = new DALFactory.DALPRodductFactory();
                //var d = factory.GetDALProduct();

                //desde el DALExtra
                //var d = new DALExtra.Products();

                //Codigo desde DALJson
               // var d = new DALJson.Product();
                //Codigo duro o quemado
                //var d = new DAL.Product();
                //Desde la base de datos
               //var d = new DALMSQL.Product();
                Result = d.GetProductById(Id);

                if (Result == null && errorEvent != null)
                {
                    errorEvent(this, new ErrorEventArgs("Producto no encontrado"));

                }


                errorEvent?.Invoke(this, new ErrorEventArgs(Factory.GetIdentity(d)));
            }
            else
            {
                errorEvent?.Invoke(this, new ErrorEventArgs("El ID debe ser mayor que cero"));

                return null;
            }

            return Result;
        }
    }
}
