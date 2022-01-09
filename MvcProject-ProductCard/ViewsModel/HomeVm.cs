using MvcProject_ProductCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject_ProductCard.ViewsModel
{
    public class HomeVm
    {
        public List<Images> imagess { get; set; }
        public List<Card> Cards { get; set; }
    }
}
