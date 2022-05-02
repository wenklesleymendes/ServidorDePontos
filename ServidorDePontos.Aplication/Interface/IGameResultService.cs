using ServidorDePontos.Core.Model;
using ServidorDePontos.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDePontos.Aplication.Interface
{
    public interface IGameResultService
    {
        public void PersisteDadosNaMemoria(List<GameResult> gameResults);
        public List<LeaderBoardDto> ConsultaDadosPersistidos();
    }
}
