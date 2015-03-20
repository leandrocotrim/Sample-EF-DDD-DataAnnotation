using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class SrvCliente : ISrvCliente
    {
        //Toda a parte do endereço nessa partial     
        public Model.Endereco FindEndereco(Guid id)
        {            
            return _repEndereco.Find(id);
        }
        public void UpdateEndereco(Model.Endereco endereco)
        {
            _repEndereco.Update(endereco);
            _repEndereco.Save();
        }
        public void RemoveEndereco(Guid id)
        {
            _repEndereco.Remove(id);
            _repEndereco.Save();
        }
    }
}
