using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SelfGuidedTours.Infrastructure.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllReadOnly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        EntityEntry Delete<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
        Task<T?> GetByIdAsync<T>(object id) where T : class;
    }
}
