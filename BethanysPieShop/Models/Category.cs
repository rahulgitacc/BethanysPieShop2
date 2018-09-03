using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    /// <summary>
    /// Get or Set Category property
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}