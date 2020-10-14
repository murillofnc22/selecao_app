namespace SelecaoApp.Domain.Models.LoginModels
{
    public class Login : ILogin
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string usrpass { get; set; }
    }
}
