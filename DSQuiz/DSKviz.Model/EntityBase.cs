﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DSKviz.Model
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}
