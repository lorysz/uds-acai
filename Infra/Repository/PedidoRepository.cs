using Infra.Entities;
using Infra.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infra.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly Context _con;
        public PedidoRepository(Context context) : base()
        {
            _con = context;
        }

        public Pedido BuscarPedido(int id)
        {
            return _con.Pedido.Find(id);
        }

        public int CadastrarPedido(Pedido pedido)
        {
            _con.Pedido.Add(pedido);
            _con.SaveChanges();

            return (int)pedido.IdPedido;
        }
    }
}
