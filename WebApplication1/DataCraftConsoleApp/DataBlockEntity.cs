using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DataCraftConsoleApp
{
    public class DataBlockEntity
    {
        public string ClassName { get; private set; }
        public List<DataBlockVariableEntity> Variables { get; private set; }
        public List<DataBlockFunctionEntity> Functions { get; private set; }

        public DataBlockEntity(Type t)
        {
            ClassName = t.Name;

            Variables = new List<DataBlockVariableEntity>();
            FieldInfo[] fields = t.GetFields();
            foreach(FieldInfo f in fields)
            {
                DataBlockVariableEntity e = new DataBlockVariableEntity(f);
                Variables.Add(e);
            }

            Functions = new List<DataBlockFunctionEntity>();
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                ParameterInfo[] p = m.GetParameters();


                DataBlockFunctionEntity e = new DataBlockFunctionEntity(m);
                Functions.Add(e);
            }


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Class Name:" + ClassName);

            sb.Append("\nVariables:");
            foreach(DataBlockVariableEntity e in Variables)
            {
                sb.Append("\n");
                sb.Append(e);
            }

            sb.Append("\nFunctions:");
            foreach (DataBlockFunctionEntity e in Functions)
            {
                sb.Append("\n");
                sb.Append(e);
            }

            return sb.ToString();
        }






    }
}
