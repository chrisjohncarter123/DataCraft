using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCraftConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCraftConsoleApp.DataBlockGroup blockGroup = new DataBlockGroup();

            Console.WriteLine(blockGroup);
            
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
