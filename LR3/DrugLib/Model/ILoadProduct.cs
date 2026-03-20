using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Model
{
    public interface ILoadProduct
    {
        Dictionary<string, List<Product>> LoadDataFromCsv();
    }
}
