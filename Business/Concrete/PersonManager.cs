﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete //Concrete ile somut - Abstract ile soyut.
{
    public class PersonManager : IApplicantService //Public yapmamız gerekiyor.
    {
        public void ApplyForMask(Person person)
        {

        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirth)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
