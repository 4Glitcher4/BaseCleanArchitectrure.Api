using System.Linq.Expressions;

namespace BaseCleanArchitectrure.Core.Interfaces.RepositoryInterfaces
{
    public interface IEntityRepository<TEntityDocument>
                where TEntityDocument : class, IBaseEntity
    {
        IQueryable<TEntityDocument> AsQueryable();

        void InsertOne(TEntityDocument entity);
        Task InsertOneAsync(TEntityDocument entity);

        void InsertMany(IEnumerable<TEntityDocument> entities);
        Task InsertManyAsync(IEnumerable<TEntityDocument> entities);

        TEntityDocument FindById(int id);
        Task<TEntityDocument> FindByIdAsync(int id);

        TEntityDocument FindOne(Expression<Func<TEntityDocument, bool>> expression);
        Task<TEntityDocument> FindOneAsync(Expression<Func<TEntityDocument, bool>> expression);

        void ReplaceOne(TEntityDocument entity);
        Task ReplaceOneAsync(TEntityDocument entity);

        void DeleteOne(TEntityDocument entity);

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
