using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCleanArchitectrure.Core.Interfaces.RepositoryInterfaces;

namespace BaseCleanArchitectrure.Core.Entities.BaseEntity
{
    public class BaseEntity : IBaseEntity
    {
        public int Id {  get; set; }
        public DateTime CreateAt {  get; set; } = DateTime.Now;
        public DateTime UpdateAt {  get; set; } = DateTime.Now;
    }
}
