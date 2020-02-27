using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class PersonalizacaoDto
    {
        public int? IdPersonalizacao { get; set; }
        public string DescricaoPersonalizacao { get; set; }
        public decimal ValorPersonalizacao { get; set; }
    }
}
