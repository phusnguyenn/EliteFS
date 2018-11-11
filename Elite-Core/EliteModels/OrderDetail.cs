using Elite_Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Core.EliteModels
{
    public class OrderDetail : BaseModel
    {
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }
        public long OrderID { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public long ProductId { get; set; }

        public int Quanlity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
