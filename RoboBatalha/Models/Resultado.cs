namespace RoboBatalha.Models
{
    public class Resultado<TEntity>
    {
        public bool EhEmpate { get; set; }
        public TEntity Vencedor { get; set; }
    }
}
