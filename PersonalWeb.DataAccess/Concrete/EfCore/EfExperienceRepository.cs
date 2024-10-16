using PersonalWeb.DataAccess.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.DataAccess.Concrete.EfCore
{
    public class EfExperienceRepository : EfEntityRepository<Experience>, IExperienceRepository
    {
        public EfExperienceRepository(PersonalWebDbContext context) : base(context)
        {
        }
    }
}
