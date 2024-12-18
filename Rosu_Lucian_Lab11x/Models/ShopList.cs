using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosu_Lucian_Lab11x.Models
{
    internal class ShopList
    {
        public int ID { get; set; }
        public string Description { get; set; } = string.Empty; // Initialize with a default value
        public DateTime Date { get; set; }
    }
}
