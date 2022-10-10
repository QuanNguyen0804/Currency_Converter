using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter.Controllers
{
    public class CurrencyConverterController : Controller
    {
        public IActionResult Index(float a, float b)
        {
            Models.CurrencyConverter res = new Models.CurrencyConverter(a, b);
            res.mul();

            return View("currencyConverterView", res);
        }
    }
}
