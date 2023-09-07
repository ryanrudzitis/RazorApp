using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class FutureModel : PageModel
    {
        private readonly ILogger<FutureModel> _logger;

        public FutureModel(ILogger<FutureModel> logger)
        {
            _logger = logger;
        }

        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }

        public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
    }
}