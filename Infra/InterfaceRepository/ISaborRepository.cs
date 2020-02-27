using Infra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.InterfaceRepository
{
    public interface ISaborRepository
    {
        Sabor GetSabor(int id);
    }
}
