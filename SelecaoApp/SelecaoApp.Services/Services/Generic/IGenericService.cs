namespace SelecaoApp.Services.Services.Generic
{
    public interface IGenericService<T> where T : class
    {
        void ValidateModel(T model);
    }
}
