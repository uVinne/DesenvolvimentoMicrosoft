using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWPF.Models
{
    [Table("Clientes")]
    class Cliente : BaseModel
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
    }
}
