using ServidorDePontos.Aplication.Interface;
using ServidorDePontos.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDePontos.Aplication.Service
{
    public class GameResultService : IGameResultService
    {
        static List<GameResult> _gameResult;
        public void PercisteDadosNaMemoria(GameResult gameResult)
        {
            _gameResult.Add(gameResult);
        }
    }
}
