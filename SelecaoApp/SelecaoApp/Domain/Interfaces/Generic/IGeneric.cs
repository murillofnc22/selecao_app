using System.Collections.Generic;

namespace SelecaoApp.Domain.Interfaces.Generic
{
    public interface IGeneric<T> where T : class
    {
        void Add(T objeto);
        void Update(T objeto);
        void Delete(T objeto);
        List<T> List();
    }
}
