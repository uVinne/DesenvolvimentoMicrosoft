using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWPF.Models
{
    [Table("ÏtensVenda")]
    class ItemVenda : BaseModel
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
