using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantServise _applicantServise;

        public PttManager()
        {
        }

        public PttManager(IApplicantServise applicantServise) 
        {
            _applicantServise = applicantServise;
        }
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person) )
                
            {
                       Console.WriteLine(person.FirstName + "Maske Verildi");

            }
        }
    }
}
