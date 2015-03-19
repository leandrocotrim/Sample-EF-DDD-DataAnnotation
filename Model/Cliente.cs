using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("cliente")]
    public class Cliente : Base
    {
        public Cliente() { Enderecos = new List<Endereco>(); }

        [Column("s_nome")]
        [DisplayName("Nome Cliente")]
        public string Nome { get; set; }
        [Column("s_profissao")]
        [DisplayName("Profissão")]
        public string Profissao { get; set; }
        [Column("n_idade")]
        public int Idade { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
