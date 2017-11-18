using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlog.Utilities
{
    public class JSONDatabase<T> : IPersistenceBehavior<T>
    {

        public JSONDatabase()
        {
                
        }

        public void Add(T obj)
        {
            //TODO: Save to JSON Logic
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
