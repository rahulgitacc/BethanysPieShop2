using BethanysPieShop.Models;
using System.Collections.Generic;

namespace BethanysPieShop.ViewModels
{
    public class PieListVIewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string Category { get; set; }
    }
}
