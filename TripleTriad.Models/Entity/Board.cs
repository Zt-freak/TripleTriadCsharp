using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Board : IBoard
    {
        public IField[,] Fields { get; set; }

        public Board() : this(3, 3)
        {
        }

        public Board(int xFields, int yFields)
        {
            Fields = new IField[xFields, yFields];
        }
    }
}
