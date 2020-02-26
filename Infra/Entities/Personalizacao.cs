using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infra.Entities
{
    public class Personalizacao
    {
        [Key]
        public int IdPersonalizacao { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int TempoPreparo { get; set; }
    }
}
