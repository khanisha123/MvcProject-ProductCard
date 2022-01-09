using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject_ProductCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public ICollection<Images> imagess { get; set; }

    }
}
