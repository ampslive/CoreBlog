using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Utilities
{
    public interface IPersistenceBehavior<T>
    {
        //void SaveToDb(T obj);
        //void SaveToJson(T obj);
        void Add(T obj);
        void Update(T obj);
    }
}
