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
    public class EducationManager : IEducationServices
    {
        private readonly IEducationRepository _educationRepository;
        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public async Task<bool> AddAsync(Education education)
        {
            return await _educationRepository.AddAsync(education);
        }

        public IQueryable<Education> GetAll()
        {
            return _educationRepository.GetAll();
        }

        public Task<Education> GetById(string id)
        {
            return _educationRepository.GetSingleAsync(id);
        }

        public bool Remove(Education education)
        {
            return _educationRepository.Remove(education);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await _educationRepository.RemoveAsync(id);
        }

        public async Task<int> SaveAsync()
        {
           return await _educationRepository.SaveAsync();
        }

        public bool Update(Education education)
        {
           return _educationRepository.Update(education);
        }
    }
}
