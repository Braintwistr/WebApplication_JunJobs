using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_JunJobs.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string VacancyName { get; set; }
        public string VacancyDescription { get; set; }
        public string VacancyMainSkills { get; set; }
        public string VacancyResposibilities{ get; set; }
        public string VacancyAboutCompany { get; set; }
        public string VacancyContacts { get; set; }
        public Vacancy()
        {

        }
    }
}
