namespace SelecaoApp.Domain.Models.LoginModels
{
    public interface ILogin
    {
        int id { get; set; }
        string usrpass { get; set; }
        string usuario { get; set; }
    }
}