using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proventeq_AzureSaasPricing.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetLoadPartial(string partialName)
        {
            return partialName switch
            {
                "StaticWebApp" => Partial("Partials/StaticWebApp"),
                "ApplicationGateway" => Partial("Partials/ApplicationGateway"),
                "ResourcePricing" => Partial("Partials/ResourcePricing"),
                _ => NotFound()
            };
        }
    }
}
