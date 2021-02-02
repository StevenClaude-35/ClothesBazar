using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesBAZAR.Entities
{
    public class Product:BaseEntity
    {
        public Category Cateory { get; set; }
        public decimal Price { get; set; }
    }
}
