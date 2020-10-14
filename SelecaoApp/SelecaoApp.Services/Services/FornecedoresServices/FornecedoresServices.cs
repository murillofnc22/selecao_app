using SelecaoApp.Domain.Models.Fornecedores;
using SelecaoApp.Services.CommomServices;
using System;
using System.Collections.Generic;

namespace SelecaoApp.Services.Services.FornecedoresServices
{
    public class FornecedoresServices : IFornecedoresService, IFornecedoresRepository
    {
        private IFornecedoresRepository _fornecedoresRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public FornecedoresServices(IFornecedoresRepository fornecedoresRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _fornecedoresRepository = fornecedoresRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(FornecedoresModel objeto)
        {
            throw new NotImplementedException();
        }

        public void Delete(FornecedoresModel objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FornecedoresModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public FornecedoresModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FornecedoresModel objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(FornecedoresModel model)
        {
            throw new NotImplementedException();
        }
    }
}
