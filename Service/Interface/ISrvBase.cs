using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISrvBase
    {
        void Add(Model.Cliente cliente);
        void Update(Model.Cliente cliente);
        void Remove(Guid id);
        IList<Model.Cliente> List();
        Model.Cliente Find(Guid id);
    }
}
