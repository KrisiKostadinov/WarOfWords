using Microsoft.AspNetCore.Mvc;

namespace WorOfWords.Web.Controllers
{
    public class LevelController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}