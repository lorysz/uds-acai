using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infra.Entities
{
    public class Tamanho
    {
        [Key]
        public int IdTamanho { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int TempoPreparo { get; set; }
    }
}
