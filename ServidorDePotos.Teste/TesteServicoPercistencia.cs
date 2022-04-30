using NUnit.Framework;
using ServidorDePontos.Core.Model;
using System;
using Xunit;

namespace ServidorDePotos.Teste
{
    public class TesteServicoPercistencia
    {
        [Fact]
        public void PercisteDadosNaMemoria()
        {
            var dados = new GameResult(1, 1, 55, DateTime.Now);            
            var servico = IGameResultService();
            servico.PercisteDadosNaMemoria(dados);

            Assert.NotNull(servico._gameResult.FirstOrDefault(s => s.PlayerId = dados.PlayerId));
        }
    }
}
