using ServidorDePontos.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDePontos.Aplication.Interface
{
    public interface IGameResultService
    {
        public void PercisteDadosNaMemoria(GameResult gameResult);
    }
}
