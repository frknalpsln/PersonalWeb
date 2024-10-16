using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Abstract
{
    public interface IEducationServices
    {
        IQueryable<Education> GetAll();
        Task<Education> GetById(string id);
        Task<bool> AddAsync(Education education);
        Task<bool> RemoveAsync(string id);
        bool Remove(Education education);
        bool Update(Education education);
        Task<int> SaveAsync();
    }
}
