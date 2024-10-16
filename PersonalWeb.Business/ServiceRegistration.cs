using Microsoft.Extensions.DependencyInjection;
using PersonalWeb.Business.Abstract;
using PersonalWeb.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistration).Assembly);
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly);
            });

            services.AddScoped<IAboutServices, AboutManager>();
            services.AddScoped<ISkillServices, SkillManager>();
            services.AddScoped<IEducationServices, EducationManager>();
            services.AddScoped<IExperienceServices, ExperienceManager>();

            return services;
        }
    }
}

