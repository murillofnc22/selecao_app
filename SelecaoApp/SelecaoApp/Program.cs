using Microsoft.Extensions.DependencyInjection;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.FornecedoresInfra;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.LoginInfra;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.ProdutosInfra;
using SelecaoApp.Services.Services.FornecedoresServices;
using SelecaoApp.Services.Services.Generic;
using SelecaoApp.Services.Services.LoginServices;
using SelecaoApp.Services.Services.ProdutosServices;
using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    static class Program
    {
        private static ServiceProvider serviceProvider;
        [STAThread]
        static void Main()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = serviceProvider.GetService<frmLogin>();
            Application.Run(login);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddSingleton<ILoginRepository, LoginRepository>();
            services.AddSingleton<IFornecedoresRepository, FornecedoresRepository>();
            services.AddSingleton<IProdutosRepository, ProdutosRepository>();            

            services.AddSingleton<frmLogin>();
        }
    }
}
