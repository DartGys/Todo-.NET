using Microsoft.EntityFrameworkCore;
using ShopExpressTest.Entities;

namespace ShopExpressTest.Interfaces.Data
{
    public interface IApplicationDbContext
    {
        DbSet<UserTask> Tasks { get; }
    }
}
