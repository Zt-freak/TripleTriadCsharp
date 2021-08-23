using System.Collections.Generic;
using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Services.Interface
{
    public interface IGameLogicService
    {
        int GetPointDifference(int baseValue, int compareValue);
        void SwitchCardOwner(ICard card, IPlayer newOwner);
        List<IField> CheckNeighbours(IField[,] fields, ICard card);
    }
}
