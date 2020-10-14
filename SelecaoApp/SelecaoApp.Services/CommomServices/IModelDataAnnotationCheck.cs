namespace SelecaoApp.Services.CommomServices
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModel<TDomainModel>(TDomainModel domainModel);
    }
}