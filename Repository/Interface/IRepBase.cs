using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepBase<T> where T : class 
    {
        IList<T> List();
        T Find(Guid id);
        void Add(T model);
        void Remove(Guid id);
        void Update(T model);
        void Save();      
    }
}
