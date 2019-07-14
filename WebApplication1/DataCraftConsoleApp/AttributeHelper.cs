using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataCraftConsoleApp
{
    public static class AttributeHelper
    {


        public static IEnumerable<Type> GetTypesWithAttribute<attribute>() where attribute : Attribute
        {


            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                if (Attribute.IsDefined(type, typeof(attribute)))
                    yield return type;
            }
        }


    }
}
