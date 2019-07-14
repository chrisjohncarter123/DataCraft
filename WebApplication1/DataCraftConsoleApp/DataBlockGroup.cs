using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataCraftConsoleApp
{
    public class DataBlockGroup
    {
        public List<DataBlockEntity> AllEntities { get; private set; }

        public DataBlockGroup()
        {
            CreateAllBlockEntities();
        }
        
        private void CreateAllBlockEntities()
        {
            // Using reflection.  
            IEnumerable<Type> dataBlockAttrs =
                AttributeHelper.GetTypesWithAttribute<DataBlock>();

            AllEntities = new List<DataBlockEntity>();
            foreach(Type t in dataBlockAttrs)
            {
                DataBlockEntity e = new DataBlockEntity(t);
                AllEntities.Add(e);  
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataBlockEntity e in AllEntities)
            {
                sb.Append(e);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
