﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApiTest.Models
{
    public class JobDes:Audit
    {
        [Key]
        public Guid JobDesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Office Office { get; set; }
    }
}
