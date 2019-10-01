using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApiTest.Models
{
    public class Audit
    {
        public bool isdelete { get; set; }
        public bool isActive { get; set; }
        public DateTime createdOn { get; set; }
        public Guid createdBy { get; set; }
        public DateTime updatedOn { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime deletedOn { get; set; }
        public Guid deleteBy { get; set; }
        public DateTime activatedOn { get; set; }
        public DateTime activatedBy { get; set; }
        public DateTime deactivatedOn { get; set; }
        public DateTime deactivatedBy { get; set; }
    }
}
