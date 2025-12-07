using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1;
using EduData.Domain.Base;
using EduData.Domain.Entities;

namespace EduData.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected EduDataContext _mysSqlContext;

        public BaseRepository(EduDataContext mysSqlContext)
        {
            _mysSqlContext = mysSqlContext;
        }
        public void AttachObject(object obj)
        {
            _mysSqlContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mysSqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _mysSqlContext.Set<TEntity>().Add(obj);
            _mysSqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _mysSqlContext.Entry(obj).State = EntityState.Modified;
            _mysSqlContext.SaveChanges();
        }
        public void Delete(object id)
        {
            _mysSqlContext.Set<TEntity>().Remove(Select(id)!);
            _mysSqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity? Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }
    }
}


