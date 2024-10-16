using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Abstract
{
    public interface IAboutServices
    {
        IQueryable<About> GetAll();
        Task<About> GetById(string id);
        Task<bool> AddAsync(About about);
        Task<bool> RemoveAsync(string id);
        bool Remove(About about);
        bool Update(About about);
        Task<int> SaveAsync();
    }
}
