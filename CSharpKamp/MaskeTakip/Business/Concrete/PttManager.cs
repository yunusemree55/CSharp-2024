using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        this._applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {

        if(_applicantService.CheckPerson(person) == true)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} adlı kişiye maske verildi");
        }


    }


}
