namespace TripleTriad.Models.Entity.Interface
{
    public interface ICard
    {
        int Id { get; set; }
        string Name { get; set; }
        int[] Points { get; set; }
        int? XCoord { get; set; }
        int? YCoord { get; set; }
        IPlayer Owner { get; set; }
    }
}