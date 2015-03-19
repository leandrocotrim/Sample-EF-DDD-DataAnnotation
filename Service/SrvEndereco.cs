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
            IRepEndereco _repEndereco = new RepEndereco();
            return _repEndereco.Find(id);
        }
    }
}
