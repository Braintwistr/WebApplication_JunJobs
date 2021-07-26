using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_JunJobs.Models
{
    public class CV
    {
        public int Id { get; set; }
        public string CvName { get; set; }
        public string CvDescription { get; set; }
        public string CvWorkExperience { get; set; }
        public string CvHardSkills { get; set; }
        public string CvEducation { get; set; }
        public string CvContacs { get; set; }
        public string CvLink { get; set; }

        public CV()
        {

        }
    }
}
