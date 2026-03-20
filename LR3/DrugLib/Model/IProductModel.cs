using ProductLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Model
{
    public interface IProductModel
    {
        Dictionary<string, List<Product>> LoadData();
        void AddOrderItem(string productName, int quantity);
        Dictionary<string, int> GetOrderItems();
        void ClearOrder();
        
    }
}
