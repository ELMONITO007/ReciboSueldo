using Entities;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {

        TEntity Load(IDataReader dr);
        TEntity Create(TEntity entity);
        List<TEntity> Read();
        TEntity ReadBy(int id);
        TEntity ReadBy(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);        
    }
}
