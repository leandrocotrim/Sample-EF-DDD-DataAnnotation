using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class SrvCliente : ISrvCliente
    {
        //Toda a parte do cliente nessa partial

        private Repository.IRepCliente _repClient;
        private Repository.IRepEndereco _repEndereco;
        public SrvCliente() { _repClient = new Repository.RepCliente(); _repEndereco = new Repository.RepEndereco(); }

        public void Add(Model.Cliente cliente)
        {
            _repClient.Add(cliente);
            _repClient.Save();            
        }
        public void Update(Model.Cliente cliente)
        {
            _repClient.Update(cliente);
            _repClient.Save();
        }
        public void Remove(Guid id)
        {
            _repClient.Remove(id);
            _repClient.Save();
        }
        public IList<Model.Cliente> List()
        {
            return _repClient.List();            
        }
        public Model.Cliente Find(Guid id)
        {
            return _repClient.Find(id);
        }

    }
}
