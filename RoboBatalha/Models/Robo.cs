using RoboBatalha.Enums;

namespace RoboBatalha.Models
{
    public abstract class Robo
    {
        public Robo(string nome)
        {
            Nome = nome;
            Status = EStatus.Desligado;
            PontosVida = 100;
        }

        public string Nome { get; private set; }
        public int PontosVida { get; protected set; }
        public EStatus Status { get; protected set; }


        public void Iniciar()
        {
            Status = EStatus.Ligado;
        }

        public void Parar()
        {
            Status = EStatus.Desligado;
        }

        public abstract int CausarDano();
        
        public void ReduzirPontosVida(int danoCausado)
        {
            PontosVida -= danoCausado;
            if(PontosVida <= 0)
            {
                PontosVida = 0;
                Status = EStatus.Destruido;
            }
        }
    }
}
