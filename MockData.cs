using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1_1
{
    internal class MockData
    {
             
      public static Dictionary<string, Person> CreateData()

        {
            Dictionary<string, Person> Persons = new Dictionary<string, Person>();

            Person person1 = new Person() { FirstName = "Kevin", LastName = "Liu", Address = "Destin, FL", MobilePhone = "555-555-5555", WorkPhone = "444-444-4444" };
            Persons.Add(person1.FullName, person1);

            Person person2 = new Person() { FirstName = "John", LastName = "Doe", Address = "Niceville, FL", MobilePhone = "444-444-4445", WorkPhone = "444-444-4446" };
            Persons.Add(person2.FullName, person2);

            return Persons;

            }
                     
        }

    }









    

