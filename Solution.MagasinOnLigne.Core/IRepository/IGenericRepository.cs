using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solution.MagasinOnLigne.Core.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll(int id);
        Task<T> Create(T element);
        Task<T> Update(T element);
        Task<T> Delete(int id);

    }
}
