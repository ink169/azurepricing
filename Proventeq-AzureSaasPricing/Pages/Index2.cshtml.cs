using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proventeq_AzureSaasPricing.Models.ViewModels;

namespace Proventeq_AzureSaasPricing.Pages
{
    public class Index2Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public PricingViewModel PricingViewModel { get; set; }

        public Index2Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
