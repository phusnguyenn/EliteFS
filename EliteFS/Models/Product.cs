using EliteFS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteFS.EliteModels
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public long CategoryId { get; set; }

        public decimal Price { get; set; }
        public string Desciption { get; set; }
    }
}
