using SelecaoApp.Domain.Models.ProdutosModels;
using SelecaoApp.Services.CommomServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecaoApp.Services.Services.ProdutosServices
{
    public class ProdutosServices : IProdutosService, IProdutosRepository
    {
        private IProdutosRepository _ProdutosRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public ProdutosServices(IProdutosRepository ProdutosRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _ProdutosRepository = ProdutosRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(Produtos objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable BuscaProdutosADO(string busca)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produtos objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produtos> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllProdutosADO()
        {
            throw new NotImplementedException();
        }

        public Produtos GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produtos objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(Produtos model)
        {
            throw new NotImplementedException();
        }
    }
}
