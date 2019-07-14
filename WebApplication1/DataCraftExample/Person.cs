using System;
using DataCraft;

namespace ExistingProjectExample
{
    

    [DataBlock]
    public class Person
    {

        [DataBlockVariable]
        public string FirstName { get; set; }

        [DataBlockVariable]
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [DataBlockFunction]
        public void UpdatePersonName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
