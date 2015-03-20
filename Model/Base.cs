using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Base
    {
        public Base()
        {
            Id = Guid.NewGuid() ;
            DataCadastro = DateTime.Now;
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
     
        [Column("d_cadastro")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }
    }
}
