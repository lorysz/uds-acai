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
            CreateMap<Pedido, PedidoDto>()
                .ForMember(x => x.DescricaoSabor, z => z.MapFrom(m => m.Sabor.Descricao))
                .ForMember(x => x.DescricaoTamanho, z => z.MapFrom(m => m.Tamanho.Descricao))
                .ForMember(x => x.TempoTotalPreparoMinutos, z => z.MapFrom(m => m.TempoTotalPreparo));

            CreateMap<CadastroPedidoDto, Pedido>();
            CreateMap<PersonalizacaoDto, PedidoPersonalizado>();
            CreateMap<PedidoPersonalizado, PersonalizacaoDto>()
                .ForMember(x => x.DescricaoPersonalizacao, z => z.MapFrom(m => m.Personalizacao.Descricao))
                .ForMember(x => x.ValorPersonalizacao, z => z.MapFrom(m => m.Personalizacao.Preco));
        }
    }
}
