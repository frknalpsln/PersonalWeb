using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Abstract
{
    public interface ISkillServices
    {
        IQueryable<Skill> GetAll();
        Task<Skill> GetById(string id);
        Task<bool> AddAsync(Skill skill);
        Task<bool> RemoveAsync(string id);
        bool Remove(Skill skill);
        bool Update(Skill skill);
        Task<int> SaveAsync();
    }
}
