using EliteFS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteFS.EliteModels
{
    public class Category : BaseModel
    {
        [ForeignKey(nameof(ParentId))]
        public Category ParentCategory { get; set; }
        public long? ParentId { get; set; }

        public string CategoryName { get; set; }
    }
}
