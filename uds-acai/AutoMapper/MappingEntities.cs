using AutoMapper;
using Infra.Entities;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uds_acai.AutoMapper
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<CadastroPedidoDto, Pedido>().ReverseMap();
            //CreateMap<AtualizarUsuarioDto, Usuario>().ReverseMap();
            //CreateMap<GridUsuarioDto, Usuario>().ReverseMap();
            //CreateMap<LoginUsuarioDto, Usuario>().ReverseMap();

            // Map indicações
            //CreateMap<CadastrarIndicacaoClienteDto, IndicacaoCliente>().ReverseMap();
            //CreateMap<AtualizarIndicacaoClienteDto, IndicacaoCliente>().ReverseMap();
            //CreateMap<IndicacaoCliente, GridIndicacaoDto>()
            //    .ForMember(x => x.NomeIndicado, o => o.MapFrom(x => x.usuario.NomeCompleto))
            //    .ReverseMap();
        }
    }
}
