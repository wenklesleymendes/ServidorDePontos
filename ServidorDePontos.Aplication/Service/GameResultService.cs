using Microsoft.Extensions.Caching.Memory;
using ServidorDePontos.Aplication.Interface;
using ServidorDePontos.Core.Model;
using ServidorDePontos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorDePontos.Service.Dto;

namespace ServidorDePontos.Aplication.Service
{
    
    public class GameResultService : IGameResultService
    {

        private readonly IMemoryCache memoryCache;
        private readonly IGameResultRepository _gameResultRepository;

        private readonly string _gameResultKey = "GameResult";

        private static List<GameResult> gameResultList = new List<GameResult>();

        public GameResultService(IMemoryCache memoryCache, IGameResultRepository gameResultRepository)
        {
            this.memoryCache = memoryCache;
            _gameResultRepository = gameResultRepository;
        }

        public void PersisteDadosNaMemoria(List<GameResult> gameResults)
        {
            gameResultList.AddRange(from result in gameResults
                                    select result);

            memoryCache.Set(_gameResultKey, gameResultList);          

            memoryCache.TryGetValue(_gameResultKey, out List<GameResult> value);

            if(value.Count == 20)
            {
                PersisteDadosNoBanco();
            }
        }

        public void PersisteDadosNoBanco()
        {
            memoryCache.TryGetValue(_gameResultKey, out List<GameResult> value);
            _gameResultRepository.AddRangeAsync(value);

            gameResultList.Clear();
        }

        public List<LeaderBoardDto> ConsultaDadosPersistidos()
        {
            List<LeaderBoardDto> leaderBoards = new();

            var result = _gameResultRepository.Busca100Primeiros();

            foreach (var teste in result)
            {
                LeaderBoardDto leaderBoard = new()
                {
                    PlayerId = teste.PlayerId,
                    Balance = teste.Win,
                    LastUpdateDate = teste.Timestamp,
                };

                leaderBoards.Add(leaderBoard);
            }

            return leaderBoards;
        }
    }
}
