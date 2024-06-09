using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SelfGuidedTours.Infrastructure.Data;

namespace SelfGuidedTours.Infrastructure.Common
{
    public class Repository : IRepository
    {
        private readonly SelfGuidedToursDbContext context;

        public Repository(SelfGuidedToursDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> DbSet<T>() where T : class => context.Set<T>();

        public async Task AddAsync<T>(T entity) where T : class
        {
            await context.AddAsync(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public EntityEntry Delete<T>(T entity) where T : class
        {
            return context.Remove(entity);
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
