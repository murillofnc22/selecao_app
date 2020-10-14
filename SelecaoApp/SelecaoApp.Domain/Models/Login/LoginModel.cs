namespace SelecaoApp.Domain.Models.Login
{
    public class LoginModel : ILoginModel
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string usrpass { get; set; }
    }
}
