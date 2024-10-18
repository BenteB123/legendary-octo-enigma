using Microsoft.EntityFrameworkCore;
using apitest.Models;

namespace apitest.Models
{
    public class DbRepository : IDbRepository
    {
        private readonly EnigmaDbContext _context;

        public DbRepository(EnigmaDbContext context)
        {
            _context = context;
        }

        public Task<Whish> CreateWhish(Whish whish)
        {
            // _context.Whishes.Add(whish);
            throw new NotImplementedException();
        }

        public Task<Whish> GetWhish(int id)
        {
            throw new NotImplementedException();
        }
    }
}