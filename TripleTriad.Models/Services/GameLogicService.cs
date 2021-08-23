using System.Collections.Generic;
using TripleTriad.Models.Entity.Interface;
using TripleTriad.Models.Services.Interface;

namespace TripleTriad.Models.Services
{
    public class GameLogicService : IGameLogicService
    {
        public List<IField> CheckNeighbours(IField[,] fields, ICard card)
        {
            List<IField> returnFields = new List<IField>();
            IField tempNeighbour;
            int tempBasePoints;
            int tempComparePoints;
            for (int i = 0; i < card.Points.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (card.XCoord + 1 < fields.GetLength(0))
                        {
                            tempNeighbour = fields[(int)card.XCoord + 1, (int)card.YCoord];
                            tempComparePoints = tempNeighbour.Occupant.Points[2];
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 1:
                        if (card.YCoord - 1 >= 0)
                        {
                            tempNeighbour = fields[(int)card.XCoord, (int)card.YCoord - 1];
                            tempComparePoints = tempNeighbour.Occupant.Points[3];
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 2:
                        if (card.XCoord - 1 >= 0)
                        {
                            tempNeighbour = fields[(int)card.XCoord - 1, (int)card.YCoord];
                            tempComparePoints = tempNeighbour.Occupant.Points[0];
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 3:
                        if (card.YCoord + 1 < fields.GetLength(1))
                        {
                            tempNeighbour = fields[(int)card.XCoord, (int)card.YCoord + 1];
                            tempComparePoints = tempNeighbour.Occupant.Points[1];
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    default:
                        continue;
                }
                tempBasePoints = card.Points[i];
                returnFields.Add(tempNeighbour);

                if (GetPointDifference(tempBasePoints, tempComparePoints) > 0)
                    SwitchCardOwner(tempNeighbour.Occupant, card.Owner);
            }
            return returnFields;
        }

        public int GetPointDifference(int baseValue, int compareValue)
        {
            return baseValue - compareValue;
        }

        public void SwitchCardOwner(ICard card, IPlayer newOwner)
        {
            card.Owner = newOwner;
        }
    }
}
