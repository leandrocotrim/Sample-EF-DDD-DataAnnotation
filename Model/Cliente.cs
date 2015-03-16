using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("cliente")]
    public class Cliente : Base
    {
        protected Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        [Column("s_nome")]
        public string Nome { get; set; }
        [Column("s_profissao")]
        public string Profissao { get; set; }
        [Column("n_idade")]
        public int Idade { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
