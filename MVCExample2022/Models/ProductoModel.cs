using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample2022.Models
{
    public class ProductoModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}