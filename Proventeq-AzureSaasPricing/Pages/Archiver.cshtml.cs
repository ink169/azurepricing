using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proventeq_AzureSaasPricing.Models;
using Proventeq_AzureSaasPricing.Models.Domain;
using Proventeq_AzureSaasPricing.Models.ViewModels;

namespace Proventeq_AzureSaasPricing.Pages
{
    public class ArchiverModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public PricingViewModel PricingViewModel { get; set; }

        public ArchiverModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            PricingViewModel = new PricingViewModel() { ResourceConfigs = new List<Models.Domain.ResourceConfig>() };
            PricingViewModel.ResourceConfigs.Add(new ResourceConfig() { ResourceName = "Static Web App", ResourceType = ResourceType.StaticWebApp, Bandwidth = 100, Tier = Tier.Standard, Cost = 9.00M });
        }
    }
}
