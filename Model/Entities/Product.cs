﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        public string Code { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<CommandProduct> CommandProducts { get; set; }

        public virtual ICollection<LogProduct> LogProducts { get; set; }
    }
}
