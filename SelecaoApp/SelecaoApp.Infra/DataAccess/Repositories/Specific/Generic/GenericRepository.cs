using Microsoft.EntityFrameworkCore;
using SelecaoApp.Infra.Configuration;
using SelecaoApp.Services.Services.Generic;
using System.Collections.Generic;
using System.Linq;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public GenericRepository()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public void Add(T objeto)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                data.Set<T>().Add(objeto);
                data.SaveChanges();
            }
        }
        public void Delete(T objeto)
        {
            using (var data = new ContextBase(_OptionsBuilder))
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
            using (var data = new ContextBase(_OptionsBuilder))
            {                
                data.Entry<T>(objeto).State = EntityState.Modified;
                data.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return data.Set<T>().AsNoTracking().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return data.Set<T>().Find(id);
            }
        }
    }
}
