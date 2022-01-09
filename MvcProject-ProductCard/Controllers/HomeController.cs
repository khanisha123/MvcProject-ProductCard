using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcProject_ProductCard.DAL;
using MvcProject_ProductCard.Models;
using MvcProject_ProductCard.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject_ProductCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Images> imagesproduct = _context.Images.ToList();
            List<Card> cards = _context.cards.Include(x=>x.imagess).ToList();
            HomeVm home = new HomeVm();
            home.imagess = imagesproduct;
            home.Cards = cards;
            return View(home);
            
        }
    }
}
