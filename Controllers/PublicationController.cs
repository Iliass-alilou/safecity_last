using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SafeCity2607last.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Publication.RoleName)]
    public class PublicationController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}