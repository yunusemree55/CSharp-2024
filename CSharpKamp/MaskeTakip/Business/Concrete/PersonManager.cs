﻿using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{

    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(person.IdentityNumber), person.FirstName, person.LastName, person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }



}
