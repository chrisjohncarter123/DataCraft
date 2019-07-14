using System;
using System.Collections.Generic;
using DataCraft;

namespace DataCraftConsoleApp
{
    
    public class Person
    {

        private static List<Person> allPersons = new List<Person>();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AddToAllPersons();
        }
        public void UpdatePersonName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private void AddToAllPersons()
        {
            allPersons.Add(this);
        }
        
        public static Person[] GetAllPersons()
        {
            return allPersons.ToArray();
        }

    }
}
