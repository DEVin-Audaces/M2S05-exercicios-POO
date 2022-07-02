namespace RoboBatalha.Models
{
    public class RoboBatalhaPesado : Robo
    {
        public RoboBatalhaPesado(string nome)
            : base(nome)
        {

        }

        public override int CausarDano()
        {
            switch (Status)
            {
                case Enums.EStatus.Ligado:
                    Status = Enums.EStatus.Aguardando;
                    return 20;
                case Enums.EStatus.Aguardando:
                    Status = Enums.EStatus.Ligado;
                    return 0;
                case Enums.EStatus.Desligado:
                case Enums.EStatus.Destruido:
                default:
                    return 0;
            }
        }
    }
}
