using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryBase11<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Dispose();
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Remove(TEntity obj);
        void Update(TEntity obj);
    }
}