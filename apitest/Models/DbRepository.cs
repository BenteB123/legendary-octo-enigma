using Microsoft.EntityFrameworkCore;
using apitest.Models;

namespace apitest.Models
{
    public class DbRepository : IDbRepository
    {
        private readonly AppDbContext _context;

        public DbRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Whish> CreateWhish(Whish whish)
        {
            throw new NotImplementedException();
        }

        public Task<Whish> GetWhish(int id)
        {
            throw new NotImplementedException();
        }
    }
}