using BaseCleanArchitectrure.Core.Interfaces.RepositoryInterfaces;
using BaseCleanArchitectrure.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseCleanArchitectrure.Infrastructure.Repository
{
    public class EntityRepository<TEntityDocument> : IEntityRepository<TEntityDocument>
        where TEntityDocument : class, IBaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public EntityRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntityDocument> AsQueryable()
        {
            try
            {
                return _dbContext.Set<TEntityDocument>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteOne(TEntityDocument entity)
        {
            try
            {
                _dbContext.Set<TEntityDocument>().Remove(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntityDocument FindById(int id)
        {
            try
            {
                return _dbContext.Set<TEntityDocument>().FirstOrDefault(doc => doc.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TEntityDocument> FindByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Set<TEntityDocument>().FirstOrDefaultAsync(doc => doc.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntityDocument FindOne(Expression<Func<TEntityDocument, bool>> expression)
        {
            try
            {
                return _dbContext.Set<TEntityDocument>().FirstOrDefault(expression);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TEntityDocument> FindOneAsync(Expression<Func<TEntityDocument, bool>> expression)
        {
            try
            {
                return await _dbContext.Set<TEntityDocument>().FirstOrDefaultAsync(expression);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertMany(IEnumerable<TEntityDocument> entities)
        {
            try
            {
                _dbContext.Set<TEntityDocument>().AddRange(entities);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task InsertManyAsync(IEnumerable<TEntityDocument> entities)
        {
            try
            {
                await _dbContext.Set<TEntityDocument>().AddRangeAsync(entities);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertOne(TEntityDocument entity)
        {
            try
            {
                _dbContext.Set<TEntityDocument>().Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task InsertOneAsync(TEntityDocument entity)
        {
            try
            {
                await _dbContext.Set<TEntityDocument>().AddAsync(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ReplaceOne(TEntityDocument entity)
        {
            try
            {
                var document = _dbContext.Set<TEntityDocument>().FirstOrDefault(doc => doc.Id == entity.Id);
                _dbContext.Set<TEntityDocument>().Entry(document).CurrentValues.SetValues(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task ReplaceOneAsync(TEntityDocument entity)
        {
            try
            {
                var document = await _dbContext.Set<TEntityDocument>().FirstOrDefaultAsync(doc => doc.Id == entity.Id);
                _dbContext.Set<TEntityDocument>().Entry(document).CurrentValues.SetValues(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
