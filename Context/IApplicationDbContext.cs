using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserPersonApi.Models;

namespace UserPersonApi.Context
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }

        Task<int> SaveChanges();
    }
}