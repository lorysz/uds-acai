using Infra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.InterfaceRepository
{
    public interface ITamanhoRepository
    {
        Tamanho GetTamanho(int id);
    }
}
