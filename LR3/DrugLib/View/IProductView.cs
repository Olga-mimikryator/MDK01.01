using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public interface IProductView
    {
        void ShowCategories(List<string> categories);
        void ShowDrugsInCategory(List<Product> product);
        void ShowDrugDetails(Product product);
        void ShowOrderSummary(Dictionary<string, int> orderItems);
        string GetSelectedCategory();
        Product GetSelectedDrug();
        int GetOrderQuantity();
    }
}
