using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}
