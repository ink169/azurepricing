namespace Proventeq_AzureSaasPricing.Models.Domain
{
    public class ResourceConfig
    {
        public string ResourceName { get; set; }
        public Tier Tier { get; set; }

        public Decimal Cost { get; set; }

        public int Bandwidth { get; set; }





    }
}
