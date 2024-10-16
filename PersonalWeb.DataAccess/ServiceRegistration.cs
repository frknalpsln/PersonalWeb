using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalWeb.DataAccess.Abstract;
using PersonalWeb.DataAccess.Concrete;
using PersonalWeb.DataAccess.Concrete.EfCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<PersonalWebDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IAboutRepository, EfAboutRepository>();
            services.AddScoped<IEducationRepository, EfEducationRepository>();
            services.AddScoped<ISkillRepository, EfSkillRepository>();
            services.AddScoped<IExperienceRepository, EfExperienceRepository>();            
        }
    }
}
