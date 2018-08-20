using System;
namespace DALMSQL
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product:ProductInterface.IProduct
    {
        public Entities.Product GetProductById(int Id)
        {
            Entities.Product product = null;

            var connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=.;Initial Catalog=ProductDb;Integrated Security=SSPI;";
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = $"Select * from Products where ProductId = {Id}";
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                product = new Entities.Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    UnitInStock = Convert.ToInt32(reader["UnitInStock"]),
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),

                };
            }

            connection.Dispose();

            return product;
        }
    }
}
