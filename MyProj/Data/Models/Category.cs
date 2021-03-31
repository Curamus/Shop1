using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string caregoryName { set; get; }
        public string desc { set; get; }
        public virtual List<Product> Products { set; get; }
    }
}
