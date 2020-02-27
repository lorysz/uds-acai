using Infra.Entities;
using Infra.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository
{
    public class PersonalizacaoRepository : IPersonalizacaoRepository
    {
        private readonly Context _con;
        public PersonalizacaoRepository(Context context) : base()
        {
            _con = context;
        }

        public List<Personalizacao> GetPersonalizacao(List<PedidoPersonalizado> personalizacoes)
        {
            return _con.Personalizacao.Where(x => personalizacoes.Select(x => x.IdPersonalizacao).Contains(x.IdPersonalizacao)).ToList();
        }
    }
}
