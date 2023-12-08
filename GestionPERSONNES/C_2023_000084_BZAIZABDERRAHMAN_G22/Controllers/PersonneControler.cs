using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_2023_000084_BZAIZABDERRAHMAN_G22.Controllers
{
    public class PersonneControler : Controller
    {
        public ActionResult Index()
        {
            PERSONNES personnes = new PERSONNES();
            return View(personnes.All());
        }

        
      
    }
}
