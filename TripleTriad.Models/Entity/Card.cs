using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Card : ICard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IPlayer Owner { get; set; }
        public int? XCoord { get; set; }
        public int? YCoord { get; set; }
        public int[] Points { get; set; }

        public Card(IPlayer owner, int valueRight, int valueUp, int valueLeft, int valueDown) : this(owner, new int[] { valueRight, valueUp, valueLeft, valueDown })
        {
        }
        public Card(IPlayer owner, int[] points)
        {
            Owner = owner;
            Points = points;
        }
    }
}
