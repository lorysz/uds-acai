using Infra.Entities;
using Infra.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class SaborRepository : ISaborRepository
    {
        private readonly Context _con;
        public SaborRepository(Context context) : base()
        {
            _con = context;
        }

        public Sabor GetSabor(int id)
        {
            return _con.Sabor.Find(id);
        }
    }
}
