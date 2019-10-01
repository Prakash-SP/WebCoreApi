using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApiTest.Models
{
    public class Office:Audit
    {
        
        [Key]
        public Guid OfficeId { get; set; }
        public string Name { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Company Company { get; set; }
        
    }
}
