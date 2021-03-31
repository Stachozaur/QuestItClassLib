using Job.it_classes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.Entities
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public User User { get; set; }
        public Quest Quest { get; set; }
    }
}
