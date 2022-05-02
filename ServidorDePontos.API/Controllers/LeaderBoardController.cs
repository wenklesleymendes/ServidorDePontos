using Microsoft.AspNetCore.Mvc;
using ServidorDePontos.Aplication.Interface;

namespace ServidorDePontos.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderBoardController : Controller
    {
        private readonly IGameResultService gameResultService;

        public LeaderBoardController(IGameResultService gameResultService)
        {
            this.gameResultService = gameResultService;
        }

        [Route("consulta")]
        [HttpGet]
        public IActionResult ContsultaGameResult()
        {
            var result = gameResultService.ConsultaDadosPersistidos();

            return Ok(result);
        }
    }
}
