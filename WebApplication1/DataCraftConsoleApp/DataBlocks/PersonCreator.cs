using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCraftConsoleApp
{
    [DataBlock]
    class PersonCreator
    {
        [DataBlockFunction] 
        public void CreatePerson(string firstName, string lastName)
        {
            Person p = new Person(firstName, lastName);


        }
    }
}
