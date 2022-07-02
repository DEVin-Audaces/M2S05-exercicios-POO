using RoboBatalha.Models;
using System;

namespace RoboBatalha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robo robo1 = new RoboBatalhaLeve("R2D2");
            Robo robo2 = new RoboBatalhaPesado("Optimusprime");

            robo1.Iniciar();
            robo2.Iniciar();

            var resultado = PartidaBatalha.Batalhar(robo1, robo2);

            if (resultado.EhEmpate)
            {
                Console.WriteLine("Partida empatada!");
            }else
                Console.WriteLine($"Robo vencedor: {resultado.Vencedor.Nome}");


        }
    }
}
