using Microsoft.AspNetCore.Mvc;
using MTG_Application.Data;
using MTG_Application.Models;
using MTG_Application.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MTG_Application.Controllers
{
    public class CollectionController : Controller
    {
        private CardDbContext context;

        public CollectionController(CardDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Card> cards = new List<Card>(context.Cards.ToList());
            return View(cards);
        }

        public IActionResult Add()
        {
            AddCardViewModel addCardViewModel = new AddCardViewModel();

            return View(addCardViewModel);
        }
    }
}
