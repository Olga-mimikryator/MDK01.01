using ProductLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class FileProductStorage : ILoadProduct
    {
        public Dictionary<string, List<Product>> LoadDataFromCsv()
        {
            Dictionary<string, List<Product>> result = new Dictionary<string, List<Product>>();

            using (StreamReader reader = new StreamReader("data.csv", Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] productInfo = line.Split(';');

                    string category = productInfo[0];
                    string name = productInfo[1];
                    string price = productInfo[2];
                    string manufacturer = productInfo[3];
                    string date = productInfo[4];
                    string provider = productInfo[5];
                    string imagePath = productInfo[6];

                    Product product = new Product(name, price, manufacturer, date, provider, imagePath);

                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Product>();
                    }

                    result[category].Add(product);
                }
            }

            return result;
        }
    }
}
