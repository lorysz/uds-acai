using Infra.Entities;
using Infra.InterfaceRepository;
using Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repoPedido;
        private readonly ITamanhoRepository _repoTamanho;
        private readonly ISaborRepository _repoSabor;
        private readonly IPersonalizacaoRepository _repoPersonalizacao;
        public PedidoService(IPedidoRepository repoPedido, ITamanhoRepository repoTamanho, ISaborRepository repoSabor, IPersonalizacaoRepository repoPersonalizacao)
        {
            _repoPedido = repoPedido;
            _repoTamanho = repoTamanho;
            _repoSabor = repoSabor;
            _repoPersonalizacao = repoPersonalizacao;
        }

        public Pedido BuscarPedido(int id)
        {
            return _repoPedido.BuscarPedido(id);
        }

        public int CadastrarPedido(Pedido pedido)
        {
            var tamanho = _repoTamanho.GetTamanho(pedido.IdTamanho);

            if (tamanho == null)
            {
                throw new Exception("Tamanho não cadastrado");
            }

            var sabor = _repoSabor.GetSabor(pedido.IdSabor);

            if (sabor == null)
            {
                throw new Exception("Sabor não cadastrado");
            }

            pedido.TempoTotalPreparo = sabor.TempoPreparo + tamanho.TempoPreparo;
            pedido.ValorTotal = tamanho.Valor;

            if (pedido.Personalizacao.Count() > 0)
            {
                var personalizacoes = _repoPersonalizacao.GetPersonalizacao(pedido.Personalizacao);
                if (personalizacoes == null)
                {
                    throw new Exception("Personalização não cadastrada");
                }

                pedido.TempoTotalPreparo += personalizacoes.Sum(x => x.TempoPreparo);
                pedido.ValorTotal += personalizacoes.Sum(x => x.Preco);
            }

            return _repoPedido.CadastrarPedido(pedido);
        }
    }
}
