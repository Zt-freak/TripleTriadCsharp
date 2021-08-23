using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Player : IPlayer
    {
        public Player ()
        {

        }
        public Player (IEnumerable<ICard> cards)
        {
            Deck = cards;
        }
        public int Id { get; set; }
        public Color TeamColor { get; set; }
        public IEnumerable<ICard> Deck { get; set; }
    }
}
