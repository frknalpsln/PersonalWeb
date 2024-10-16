using PersonalWeb.Business.Abstract;
using PersonalWeb.DataAccess.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business.Concrete
{
    public class AboutManager : IAboutServices
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task<bool> AddAsync(About about)
        {
            return await _aboutRepository.AddAsync(about);
        }

        public IQueryable<About> GetAll()
        {
            return _aboutRepository.GetAll();
        }

        public Task<About> GetById(string id)
        {
            return _aboutRepository.GetSingleAsync(id);
        }

        public bool Remove(About about)
        {
            return _aboutRepository.Remove(about);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _aboutRepository.RemoveAsync(id);
        }

        public async Task<int> SaveAsync()
        {
            return await _aboutRepository.SaveAsync();
        }

        public bool Update(About about)
        {
            return _aboutRepository.Update(about);
        }
    }
}
