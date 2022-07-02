namespace RoboBatalha.Models
{
    public class RoboBatalhaLeve : Robo
    {
        public RoboBatalhaLeve(string nome)
            : base(nome)
        {

        }

        public override int CausarDano()
        {
            if (Status == Enums.EStatus.Ligado)
                return 10;

            return 0;
        }
    }
}
