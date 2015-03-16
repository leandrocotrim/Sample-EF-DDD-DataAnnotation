using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepBase<T> : IRepBase<T> where T : class
    {
        protected DataContext DB;

        public RepBase () { DB = new DataContext(); }
        public IList<T> List() { return DB.Set<T>().ToList(); }
        public T Find(Guid id) { return DB.Set<T>().Find(id); }
        public void Add(T model) { DB.Set<T>().Add(model); }
        public void Remove(Guid id) { var model = Find(id);  DB.Set<T>().Remove(model); }
        public void Update(T model) { DB.Entry<T>(model).State = System.Data.Entity.EntityState.Modified; }
        public void Save() { DB.SaveChanges(); }
    }
}
