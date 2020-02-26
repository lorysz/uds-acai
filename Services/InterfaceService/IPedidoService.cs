using Infra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.InterfaceService
{
    public interface IPedidoService
    {
        int CadastrarPedido(Pedido pedido);
        Pedido BuscarPedido(int id);
    }
}
