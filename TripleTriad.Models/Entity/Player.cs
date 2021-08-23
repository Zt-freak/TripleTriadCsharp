using System.Collections.Generic;
using System.Drawing;
using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public Color TeamColor { get; set; }
        public IEnumerable<ICard> Deck { get; set; }
    }
}
