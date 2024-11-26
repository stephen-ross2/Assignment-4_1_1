using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1_1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }


        private string fullName;

        public string FullName
        {
            get
            {
                return LastName + FirstName;
            }


        }


    }
}




