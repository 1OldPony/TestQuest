using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestQuest.Context;

namespace TestQuest.Controllers
{
    public class PostServerController : Controller
    {
        private readonly TestQuestContext _context;
        public PostServerController(TestQuestContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLetters = await _context.Letters.ToListAsync();
            return View(allLetters);
        }
    }
}
