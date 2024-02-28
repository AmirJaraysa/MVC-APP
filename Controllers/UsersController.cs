using Microsoft.AspNetCore.Mvc;
using AJaraysa.Models;

namespace AJaraysa.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult AJView()
        {
            return View(uc.JaraysaAtables.ToList());
        }
    }
}
