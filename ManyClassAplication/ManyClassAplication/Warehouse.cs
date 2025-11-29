using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    public class Warehouse
    {
        private int id_;
        private Dictionary<Goods, int> goodsCount_ = new Dictionary<Goods, int>();
        private string location_;

        public void SetId(int id)
        {
            id_ = id;
        }
        public int GetId()
        {
            return id_;
        }
        public void SetLocation(string location)
        {
            location_ = location;
        }
        public string GetLocation()
        {
            return location_;
        }
        public void SetGoodsCount(Goods goods, int count)
        {
            goodsCount_.Add(goods, count);
        }
        public Dictionary<Goods, int> GetGoodsCount()
        {
            return goodsCount_;
        }

        public void PrintGoodsCountWarehouse()
        {
            Console.WriteLine("Все товары на складе:");
            foreach(Goods goods in goodsCount_.Keys)
            {
                int count = goodsCount_[goods];
                Console.WriteLine($"Товар: {goods.GetName()}");
                Console.WriteLine($"Количество: {count}");
            }
        }
        //public int CalcFullCountGoods()
        //{
        //    int fullCount = 0;
        //    foreach (Goods goods in goodsCount_.Keys)
        //    {
        //        int count = goodsCount_[goods];
        //        fullCount += count;
        //    }
        //    return fullCount;
        //}
        public double CalcFullPriceGoodsInWarehouse()
        {
            double fullPrice = 0;
            foreach (Goods goods in goodsCount_.Keys)
            {
                int count = goodsCount_[goods];
                double price = goods.GetPrice();
                fullPrice += price*count;
            }
            return fullPrice;
        }

    }
}
