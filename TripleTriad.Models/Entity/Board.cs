using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Board : IBoard
    {
        public Field[,] Fields { get; set; }

        public Board() : this(3, 3)
        {
        }

        public Board(int xFields, int yFields)
        {
            Fields = new Field[xFields, yFields];
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    Fields[i, j] = new Field();
                }
            }
        }
    }
}
