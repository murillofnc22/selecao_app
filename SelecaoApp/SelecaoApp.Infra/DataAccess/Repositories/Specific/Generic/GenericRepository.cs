using SelecaoApp.Services.Services.Generic;
using System.Collections.Generic;
using System.Data.Entity;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T objeto)
        {
            using (DBEntities data = new DBEntities())
            {
                data.Set<T>().Add(objeto);
                data.SaveChanges();
            }
        }
        public void Delete(T objeto)
        {
            using (DBEntities data = new DBEntities())
            {
                var entry = data.Entry(objeto);
                if (entry.State == EntityState.Detached)
                    data.Set<T>().Attach(objeto);
                data.Set<T>().Remove(objeto);
                data.SaveChanges();
            }
        }
        public void Update(T objeto)
        {
            using (DBEntities data = new DBEntities())
            {
                data.Entry<T>(objeto).State = System.Data.Entity.EntityState.Modified;
                data.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (DBEntities data = new DBEntities())
            {
                return data.Set<T>().AsNoTracking();
            }
        }

        public T GetById(int id)
        {
            using (DBEntities data = new DBEntities())
            {
                return data.Set<T>().Find(id);
            }
        }
    }
}
