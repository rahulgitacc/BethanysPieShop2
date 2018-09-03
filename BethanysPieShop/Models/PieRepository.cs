using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pie> Pies
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category).ToList();
            }
        }

        public IEnumerable<Pie> PieOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek).ToList();
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.Where(p => p.PieId == pieId).FirstOrDefault();
        }
    }
}
