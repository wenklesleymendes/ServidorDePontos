using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDePontos.Core.Model
{
    public class GameResult
    {
        public GameResult(int playerId, int gameId, int win, DateTime timestamp)
        {
            PlayerId = playerId;
            GameId = gameId;
            Win = win;
            Timestamp = timestamp;
        }

        public long PlayerId { get; set; }
        public long GameId { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
