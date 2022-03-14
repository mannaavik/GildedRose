using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.DataLayer
{
    public interface IProduct
    {
        IList<Item> getItems();
    }
}
