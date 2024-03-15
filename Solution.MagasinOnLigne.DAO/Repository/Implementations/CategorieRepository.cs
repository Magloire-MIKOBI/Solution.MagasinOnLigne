using Solution.MagasinOnLigne.Core.EntitiesData;
using Solution.MagasinOnLigne.Core.IRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solution.MagasinOnLigne.DAO.Repository.Implementations
{
    public class CategorieRepository : ICategorieRepository
    {
        public Task<CategorieModel> Create(CategorieModel element)
        {
            throw new NotImplementedException();
        }

        public Task<CategorieModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategorieModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategorieModel>> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategorieModel> Update(CategorieModel element)
        {
            throw new NotImplementedException();
        }
    }
}
