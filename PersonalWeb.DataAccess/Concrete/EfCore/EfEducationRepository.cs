using PersonalWeb.DataAccess.Abstract;
using PersonalWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.DataAccess.Concrete.EfCore
{
    public class EfEducationRepository : EfEntityRepository<Education>, IEducationRepository
    {
        public EfEducationRepository(PersonalWebDbContext context) : base(context)
        {
        }
    }
}
