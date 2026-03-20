using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Model
{
    public class CsvProductModel : IProductModel
    {
        private Dictionary<string, List<Product>> product_ = new Dictionary<string, List<Product>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileProductStorage fileStorage_ = new FileProductStorage();

        public CsvProductModel()
        {
            product_ = fileStorage_.LoadDataFromCsv();
        }
        public void AddOrderItem(string productName, int quantity)
        {
            if (orderItems_.ContainsKey(productName))
            {
                orderItems_[productName] += quantity;
            }
            else
            {
                orderItems_[productName] = quantity;
            }
        }

        public void ClearOrder()
        {
            orderItems_.Clear();
        }

        public Dictionary<string, int> GetOrderItems()
        {
            return orderItems_;
        }

        public Dictionary<string, List<Product>> LoadData()
        {
            return product_;
        }

        public Dictionary<string, List<Product>> LoadDataFromCsv()
        {
            throw new NotImplementedException();
        }
    }
}
