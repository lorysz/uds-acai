using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infra.Entities
{
    public class Pedido
    {
        [Key]
        public int? IdPedido { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? TempoTotalPreparo { get; set; }
        public int IdSabor { get; set; }
        public int IdTamanho { get; set; }
        [ForeignKey("IdSabor")]
        public Sabor Sabor { get; set; }
        [ForeignKey("IdTamanho")]
        public Tamanho Tamanho { get; set; }
        public List<PedidoPersonalizado> Personalizacao { get; set; }

        public Pedido()
        {
            Personalizacao = new List<PedidoPersonalizado>();
        }
    }
}
