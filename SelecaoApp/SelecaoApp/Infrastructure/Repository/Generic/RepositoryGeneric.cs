using Microsoft.Win32.SafeHandles;
using SelecaoApp.Domain.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;

namespace SelecaoApp.Infrastructure.Repository
{
    //public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    //{
    //    public void Add(T objeto)
    //    {
    //        using (DBEntities data = new DBEntities())
    //        {
    //            data.Set<T>().Add(objeto);
    //            data.SaveChanges();
    //        }
    //    }
    //    public void Delete(T objeto)
    //    {
    //        using (DBEntities data = new DBEntities())
    //        {
    //            var entry = data.Entry(objeto);
    //            if (entry.State == EntityState.Detached)
    //                data.Set<T>().Attach(objeto);
    //            data.Set<T>().Remove(objeto);
    //            data.SaveChanges();
    //        }
    //    }
    //    public void Update(T objeto)
    //    {
    //        using (DBEntities data = new DBEntities())
    //        {
    //            data.Entry<T>(objeto).State = System.Data.Entity.EntityState.Modified;
    //            data.SaveChanges();
    //        }
    //    }

    //    public List<T> List()
    //    {
    //        using (DBEntities data = new DBEntities())
    //        {
    //            return data.Set<T>().AsNoTracking().ToList();
    //        }
    //    }

    //    public T GetEntityById(long id)
    //    {
    //        using (DBEntities data = new DBEntities())
    //        {
    //            return data.Set<T>().Find(id);
    //        }
    //    }

    //    #region Disposed
    //    //Flag: Has dispose already been called?
    //    bool disposed = false;
    //    //Instantiate a SafeHandle instance.
    //    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

    //    //Public implementation of dispose pattern callable by consumers.
    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    //Protected implementation of Dispose pattern.
    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (disposed)
    //            return;

    //        if (disposing)
    //        {
    //            handle.Dispose();
    //            // Free any other managed objects here.
    //            //
    //        }

    //        disposed = true;
    //    }
    //    #endregion
    //}
}
