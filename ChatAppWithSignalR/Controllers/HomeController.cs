using ChatAppWithSignalR.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Controllers
{
    public class HomeController : Controller
    {
        private ChatContext _context;
        public HomeController(ChatContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var messages = _context.messages.ToList();

            return View(messages);
        }
    }
}
