using SelecaoApp.Domain.Models.FornecedoresModels;
using SelecaoApp.Services.CommomServices;
using System;
using System.Collections.Generic;
using System.Data;

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

        public void Add(Fornecedores objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable BuscaFornecedoresADO(string busca)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fornecedores objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedores> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllFornecedoresADO()
        {
            throw new NotImplementedException();
        }

        public Fornecedores GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetIdFornecedorByName(string nome)
        {
            throw new NotImplementedException();
        }

        public string GetNomeFornecedorById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Fornecedores objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(Fornecedores model)
        {
            throw new NotImplementedException();
        }
    }
}
