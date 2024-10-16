using PersonalWeb.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Entities.Concrete
{
    public class Experience : BaseEntity
    {
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
