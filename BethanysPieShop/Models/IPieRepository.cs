using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PieOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}
