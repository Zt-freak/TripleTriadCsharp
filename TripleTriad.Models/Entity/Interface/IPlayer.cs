using System.Collections.Generic;
using System.Drawing;

namespace TripleTriad.Models.Entity.Interface
{
    public interface IPlayer
    {
        int Id { get; set; }
        Color TeamColor { get; set; }
        IEnumerable<ICard> Deck { get; set; }
    }
}