using Elite_Core.EliteModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Core.Service
{
    public class BaseModel : IBaseModel
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; } = false;

        [ForeignKey(nameof(CreatorUserId))]
        public User CreationUser{ get; set; }
        public long? CreatorUserId { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(DeleteUserId))]
        public User DeletedUser { get; set; }
        public long? DeleteUserId { get; set; }

        public DateTime? DeletedTime { get; set; }
    }
}
