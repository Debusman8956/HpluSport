using HpluSport.AppHost.Models;

namespace HpluSport.Models
{



    internal class Category
    {
        public int Id { get; set; }

        public String Name { get; set; } = string.Empty;

        public virtual List<Product> Products { get; set; }
    }
}
