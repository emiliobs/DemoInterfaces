using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALJson
{
    public class Product: ProductInterface.IProduct
    {
      public Entities.Product GetProductById(int Id)
        {
            Entities.Product product;
            using (var reader = new StreamReader("json.txt"))
            //using (var reader = new StreamReader("Products.json"))
            {
                var json = reader.ReadToEnd();

                //aqui lo deserializo con List
                var productsJson = JsonConvert.DeserializeObject<List<Entities.Product>>(json);
                  //Aquim lo deserializo con Array
                //var productsJson = JsonConvert.DeserializeObject<Entities.Product[]>(json);

                product = productsJson.Where(p=>p.ProductId.Equals(Id)).FirstOrDefault();
            }

            return product;

        }

    }

}
