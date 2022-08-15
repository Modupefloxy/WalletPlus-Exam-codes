using Microsoft.AspNetCore.Mvc;

namespace WalletPlus_Inc.Web.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
