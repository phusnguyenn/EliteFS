using Elite_Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Core.EliteModels
{
    public class Category : BaseModel
    {
        public string CategoryName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
