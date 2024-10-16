using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Abstract
{
    public interface IExperienceServices
    {
        IQueryable<Experience> GetAll();
        Task<Experience> GetById(string id);
        Task<bool> AddAsync(Experience experience);
        Task<bool> RemoveAsync(string id);
        bool Remove(Experience experience);
        bool Update(Experience experience);
        Task<int> SaveAsync();
    }
}
