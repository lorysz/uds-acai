using Infra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.InterfaceRepository
{
    public interface IPedidoRepository
    {
        int CadastrarPedido(Pedido pedido);
        Pedido BuscarPedido(int id);
    }
}
