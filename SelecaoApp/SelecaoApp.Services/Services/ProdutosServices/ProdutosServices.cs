using SelecaoApp.Domain.Models.Produtos;
using SelecaoApp.Services.CommomServices;
using System;
using System.Collections.Generic;
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

        public void Add(ProdutosModel objeto)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProdutosModel objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutosModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProdutosModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProdutosModel objeto)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(ProdutosModel model)
        {
            throw new NotImplementedException();
        }
    }
}
