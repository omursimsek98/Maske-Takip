using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) //constructer new yapıldığında çalışır
        {
            _applicantService = applicantService;   
        }
        public void GiveMask(Person person)
        {
            // PersonManager personManager=new PersonManager(); bunun yerine bağlı olduğu interface eklendi
           
            if (_applicantService.CheckPerson(person)) //==true dememiz gerekir ama default olarak zaten öyle kabul ettiği için yazmadık
            { 
                Console.WriteLine(person.FirstName + " için maske verildi " );
            }
            else
            {
              Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ " );
            
            }
        }
    }
}
