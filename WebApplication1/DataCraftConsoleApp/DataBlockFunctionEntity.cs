using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DataCraftConsoleApp
{
    public class DataBlockFunctionEntity
    {
        string methodName;

       // DataBlockParameterEntity[] parameterEntities;

        public DataBlockFunctionEntity(MethodInfo m)
        {
            methodName = m.Name;

            ParameterInfo[] ps = m.GetParameters();
          //  parameterEntities = new DataBlockParameterEntity[ps.Length];
          //  for(int i = 0; i < ps.Length; i++)
          //  {
          //      parameterEntities[i] = new DataBlockParameterEntity(ps[i]);
          //  }
        }

        public override string ToString()
        {
            return methodName;
        }
    }
}
