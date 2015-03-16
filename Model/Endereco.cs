using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("endereco")]
    public class Endereco : Base
    {
        [Column("id_cliente")]
        public Guid IdCliente { get; set; }
        [ForeignKey("IdCliente")]        
        public virtual Cliente Cliente { get; set; }
        
        [Column("s_rua")]
        public string Rua { get; set; }
        [Column("s_numero")]
        public string Numero { get; set; }
        [Column("s_bairro")]
        public string Bairro { get; set; }
        [Column("s_cidade")]
        public string Cidade { get; set; }
    }
}
