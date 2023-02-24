using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ADVFoodDbContext _dbContext;
        public DbSet<TEntity> _dbSet;
        public GenericRepository(ADVFoodDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public async Task<bool> AddEntity(TEntity entity)
        {
            bool isadded = false;
            try
            {
                _dbSet.Add(entity);
                await _dbContext.SaveChangesAsync();
                isadded = true;
            }
            catch (Exception ex)
            {
            }
            return isadded;
        }

        public async Task<bool> AddRangeofEntities(IEnumerable<TEntity> entities)
        {
            bool isadded = false;
            try
            {
                await _dbSet.AddRangeAsync(entities);
                await _dbContext.SaveChangesAsync();
                isadded = true;
            }
            catch (Exception ex)
            {
            }
            return isadded;
        }

        public async Task<bool> DeleteEntities(TEntity entity)
        {
            bool isdeleted = false;
            try
            {
                _dbSet.Remove(entity);
                isdeleted = true;
            }
            catch (Exception ex)
            {

            }
            return isdeleted;
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            IQueryable<TEntity> result = null;

            try
            {
                result = _dbSet.AsQueryable();
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public Task<bool> UpdateEntities(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

    }
}
