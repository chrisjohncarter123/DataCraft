using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCraftConsoleApp
{
    [DataBlock]
    class PersonGetter
    {
        

        [DataBlockFunction]
        public Person[] GetAllPersons()
        {
            return Person.GetAllPersons();

        }
    }
}
