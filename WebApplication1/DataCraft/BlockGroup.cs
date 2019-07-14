using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataCraft
{
    public class BlockGroup
    {
        public List<Type> allEntities { get; private set; }

        public BlockGroup()
        {
            CreateAllBlockEntities();
        }
        
        private void CreateAllBlockEntities()
        {
            // Using reflection.  
            IEnumerable<Type> dataBlockAttrs =
                AttributeHelper.GetTypesWithAttribute<DataBlock>();

            allEntities = new List<Type>();
            foreach(Type t in dataBlockAttrs)
            {
                allEntities.Add(t);
               
            }
        }
    }
}
