using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    public class ReportForWarehouse
    {
        private List<StructByGoods> Report_ = new List<StructByGoods>();

        public void AddNewStructInReport(StructByGoods newStruct)
        {
            Report_.Add(newStruct);
        }
        public string RelisReportByWarehouse()
        {
            string rows = "";
            foreach(StructByGoods infoGoods in Report_)
            {
                string row = infoGoods.goods.GetName() + infoGoods.count+ " штук по " + infoGoods.goods.GetPrice() + " рублей";
                rows += row + "\n";
            }
            return rows;
        }
    }
}
