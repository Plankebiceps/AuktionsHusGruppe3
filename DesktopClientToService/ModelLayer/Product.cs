using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuctionId { get; set; }


        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
