using ProductLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Presenter
{
    public class ProductPresenter
    {
        private IProductModel model_;
        private IProductView view_;

        public ProductPresenter(IProductModel model, IProductView view)
        {
            model_ = model;
            view_ = view;

            var allData = model_.LoadData();
            view_.ShowCategories(allData.Keys.ToList());
        }

        public void CategorySelected()
        {
            string category = view_.GetSelectedCategory();
            if (!string.IsNullOrEmpty(category))
            {
                var allData = model_.LoadData();
                if (allData.ContainsKey(category))
                {
                    view_.ShowDrugsInCategory(allData[category]);
                }
            }
        }

        public void DrugSelected()
        {
            Product product = view_.GetSelectedDrug();
            if (product != null)
            {
                view_.ShowDrugDetails(product);
            }
        }

        public void AddToOrder()
        {
            Product product = view_.GetSelectedDrug();
            int quantity = view_.GetOrderQuantity();

            if (product != null && quantity > 0)
            {
                model_.AddOrderItem(product.Name, quantity);
                view_.ShowOrderSummary(model_.GetOrderItems());
            }
        }
    }
}
