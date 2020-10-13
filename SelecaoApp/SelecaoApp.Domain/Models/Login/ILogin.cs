namespace SelecaoApp.Domain.Models.Login
{
    public interface ILogin
    {
        int id { get; set; }
        string usrpass { get; set; }
        string usuario { get; set; }
    }
}