using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infra.Entities
{
    public class Sabor
    {
        [Key]
        public int IdSabor { get; set; }
        public string Descricao { get; set; }
        public int TempoPreparo { get; set; }
    }
}
