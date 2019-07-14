using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DataCraftConsoleApp
{
    public class DataBlockVariableEntity
    {

        string variableName;
        public DataBlockVariableEntity(FieldInfo f)
        {
            variableName = f.Name;
        }

        public override string ToString()
        {
            return variableName;
        }
    }
}
