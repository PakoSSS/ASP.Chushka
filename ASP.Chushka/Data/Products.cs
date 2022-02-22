using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Chushka.Data
{
    public enum TypeType { Food, Domestic , Health , Cosmetic , Other}
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TypeType Type { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
