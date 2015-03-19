using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISrvCliente : ISrvBase
    {
        //Metodos não genericos
        Model.Endereco FindEndereco(Guid id);
    }
}
