using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClassApp
{
    public class Person
    {
        public string name;
        public string lastName;
        public string birthDate;

        public string Name { get{ return name; } set { name = value; } }

        public string LastName { get { return lastName;} set {lastName = value;} }

        public string BirthDate { get { return birthDate;} set {birthDate = value;} }

        public void info()
        {
            Console.WriteLine("\nName: " + name + "\nLastname: " + lastName + "\nBirthdate: " + birthDate);
        }

    }
}
