using Infra.Entities;
using Infra.InterfaceRepository;
using Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repo;
        public PedidoService(IPedidoRepository repo)
        {
            _repo = repo;
        }

        public Pedido BuscarPedido(int id)
        {
            return _repo.BuscarPedido(id);
        }

        public int CadastrarPedido(Pedido pedido)
        {
            return _repo.CadastrarPedido(pedido);
        }
    }
}
