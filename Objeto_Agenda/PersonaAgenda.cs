using System;
using System.Collections.Generic;
using System.Text;

namespace Objeto_Agenda
{
    public class PersonaAgenda
    {
        public string name;
        public string surname;
        public string phone;
        public string email;
        public string address;


        public PersonaAgenda(string aName, string aSurname, string aPhone, string aEmail, string aAddress)
            {
            name = aName;
            surname = aSurname;
            phone = aPhone;
            email = aEmail;
            address = aAddress;

        }

        public PersonaAgenda() { }


     }




}



