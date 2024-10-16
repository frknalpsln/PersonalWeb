using PersonalWeb.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Entities.Concrete
{
    public class About : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
