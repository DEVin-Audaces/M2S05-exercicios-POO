using System;

namespace RoboBatalha.Models
{
    public static class PartidaBatalha
    {
        public static Resultado<Robo> Batalhar(Robo robo1, Robo robo2, int quantidadePartidas = 15)
        {
            for (int i = 0; i < quantidadePartidas; i++)
            {
                Console.WriteLine($"Robo {robo1.Nome} Vida: {robo1.PontosVida} X Robo {robo2.Nome} Vida: {robo2.PontosVida}");

                AtaqueAleatorio(robo1, robo2);

                if (robo1.Status == Enums.EStatus.Destruido)
                    return ConstruirResultadoVencedor(robo2);
                if (robo2.Status == Enums.EStatus.Destruido)
                    return ConstruirResultadoVencedor(robo1);

            }

            return DefinirVencedorPorPontosVida(robo1, robo2);
        }

        private static Resultado<Robo> ConstruirResultadoVencedor(Robo vencedor)
        {
            var resultado = new Resultado<Robo>
            {
                Vencedor = vencedor,
                EhEmpate = false
            };

            return resultado;
        }

        private static Resultado<Robo> ConstruirResultadoEmpate()
        {
            var resultado = new Resultado<Robo>
            {
                EhEmpate = true
            };

            return resultado;
        }

        private static void AtaqueAleatorio(params Robo[] robos)
        {
            Random random = new Random();
            var numero = random.Next(2);
            var primeiroRobo = robos[numero];
            var segundoRobo = robos[Math.Abs(numero - 1)];

            primeiroRobo.ReduzirPontosVida(segundoRobo.CausarDano());
        }

        private static Resultado<Robo> DefinirVencedorPorPontosVida(Robo robo1, Robo robo2)
        {
            if (robo1.PontosVida > robo2.PontosVida)
                return ConstruirResultadoVencedor(robo1);
            else if (robo1.PontosVida < robo2.PontosVida)
                return ConstruirResultadoVencedor(robo2);
            else
                return ConstruirResultadoEmpate();
        }


    }

}
