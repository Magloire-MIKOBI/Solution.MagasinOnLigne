using Solution.MagasinOnLigne.Core.EntitiesData;
using Solution.MagasinOnLigne.Core.IRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solution.MagasinOnLigne.DAO.Repository.Implementations
{
    public class ProduitRepository : IProduitRepository
    {
        public Task<ProduitModel> Create(ProduitModel element)
        {
            throw new NotImplementedException();
        }

        public Task<ProduitModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProduitModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProduitModel>> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProduitModel> Update(ProduitModel element)
        {
            throw new NotImplementedException();
        }
    }
}
