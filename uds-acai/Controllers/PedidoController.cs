using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Infra.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Dto;
using Services.InterfaceService;

namespace uds_acai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPedidoService _service;
        public PedidoController(IMapper mapper, IPedidoService service)
        {
            _mapper = mapper;
            _service = service;
        }

        // GET: api/Pedido/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var pedido = _service.BuscarPedido(id);

                if (pedido == null)
                {
                    return BadRequest("Pedido não encontrado");
                }

                var retorno = _mapper.Map<PedidoDto>(pedido);

                return Ok(retorno);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST: api/Pedido
        [HttpPost]
        public IActionResult Post(CadastroPedidoDto value)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var pedidoEntity = _mapper.Map<Pedido>(value);
                               
                var idPedido = _service.CadastrarPedido(pedidoEntity);
                return Ok("IdPedido:  "  + idPedido);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
       
        }

    }
}
