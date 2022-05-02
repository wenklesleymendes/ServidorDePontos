using ServidorDePontos.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDePontos.Repository.Interfaces
{
    public interface IGameResultRepository : IDomainRepository<GameResult>
    {
        public IEnumerable<GameResult> Busca100Primeiros();
    }
}
