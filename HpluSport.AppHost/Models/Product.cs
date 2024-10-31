using HpluSport.Models;
using System.Text.Json.Serialization;


namespace HpluSport.AppHost.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public String sku { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}
