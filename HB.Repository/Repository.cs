using Backbone.Repository;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HB.Persistence
{
    public class Repository : IRepository
    {
        ISessionFactory sessionFactory;

        public Repository()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            sessionFactory = configuration.BuildSessionFactory();
        }

        public IEnumerable<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            var entities = new List<TEntity>();

            try
            {

                using (var session = sessionFactory.OpenSession())
                {
                    session.Flush();
                    entities = session.Query<TEntity>().Where(predicate).ToList();
                }

                return entities;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> FindAll<TEntity>() where TEntity : class
        {
            var entities = new List<TEntity>();

            using (var session = sessionFactory.OpenSession())
            {
                session.Flush();
                entities = session.Query<TEntity>().ToList();
            }


            return entities;
        }

        public TEntity FindById<TEntity>(int id) where TEntity : class
        {
            TEntity entity;

            using (var session = sessionFactory.OpenSession())
            {
                entity = session.Get<TEntity>(id); ;
            }

            return entity;
        }

        #region IRepository Members

        public void Save<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                using (var session = sessionFactory.OpenSession())
                {
                    session.Transaction.Begin();

                    session.SaveOrUpdate(entity);

                    session.Transaction.Commit();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
