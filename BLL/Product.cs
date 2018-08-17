namespace BLL
{
    public class Product
    {

        public event ErrorEventHandler errorEvent;
        public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);

        public Entities.Product  GetProductById(int Id)
        {
            Entities.Product Result;

            if (Id>0)
            {
                //Codigo desde DALJson
                var d = new DALJson.Product();
                //Codigo duro o quemado
                //var d = new DAL.Product();
                //Desde la base de datos
               //var d = new DALMSQL.Product();
                Result = d.GetProductById(Id);

                if (Result == null && errorEvent != null)
                 {
                   errorEvent(this, new ErrorEventArgs("Producto no encontrado"));

                }
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
