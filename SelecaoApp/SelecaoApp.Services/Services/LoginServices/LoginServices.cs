using SelecaoApp.Domain.Models.Login;
using SelecaoApp.Services.CommomServices;
using System;
using System.Collections.Generic;

namespace SelecaoApp.Services.Services.LoginServices
{
    public class LoginServices : ILoginService, ILoginRepository
    {
        private ILoginRepository _LoginRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public LoginServices(ILoginRepository LoginRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _LoginRepository = LoginRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(LoginModel objeto)
        {
            throw new NotImplementedException();
        }

        public void Delete(LoginModel objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoginModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LoginModel objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(LoginModel model)
        {
            throw new NotImplementedException();
        }
    }
}
