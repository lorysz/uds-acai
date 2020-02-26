using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class PedidoDto
    {
        public int IdPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int TempoTotalPreparo { get; set; }
        public string DescricaoSabor { get; set; }
        public string DescricaoTamanho { get; set; }
        public List<PersonalizacaoDto> Personalizacao { get; set; }
    }
}
