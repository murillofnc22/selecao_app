using System.Collections.Generic;

namespace SelecaoApp.Services.Services.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T objeto);
        void Update(T objeto);
        void Delete(T objeto);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
