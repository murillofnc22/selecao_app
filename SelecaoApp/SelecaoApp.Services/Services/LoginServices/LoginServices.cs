using SelecaoApp.Domain.Models.LoginModels;
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

        public void Add(Login objeto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Login objeto)
        {
            throw new NotImplementedException();
        }

        public Login FindLogin(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public Login GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Login objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(Login model)
        {
            throw new NotImplementedException();
        }
    }
}
