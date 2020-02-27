using Infra.Entities;
using Infra.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class TamanhoRepository : ITamanhoRepository
    {
        private readonly Context _con;
        public TamanhoRepository(Context context) : base()
        {
            _con = context;
        }

        public Tamanho GetTamanho(int id)
        {
            return _con.Tamanho.Find(id);
        }
    }
}
