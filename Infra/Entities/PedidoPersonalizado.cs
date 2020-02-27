using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infra.Entities
{
    public class PedidoPersonalizado
    {
        [Key]
        public int IdPedidoPersonalizado { get; set; }
        public int IdPedido { get; set; }
        public int IdPersonalizacao { get; set; }
        [ForeignKey("IdPedido")]
        public Pedido Pedido { get; set; }
        [ForeignKey("IdPersonalizacao")]
        public Personalizacao Personalizacao { get; set; }
    }
}
