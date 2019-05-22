using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;

namespace WebAppOne.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class PaymentInfoController : Controller
    {
        public IActionResult Index()
        {
            return View("Create");
        }


        public IActionResult Create([Bind("CardNumber", "Expires", "ExpiresYear", "Name", "Email")]PaymentInfo paymentInfo)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }

        }
    }
}