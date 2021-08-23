using TripleTriad.Models.Entity.Interface;

namespace TripleTriad.Models.Entity
{
    public class Field : IField
    {
        public ICard Occupant { get; set; }
    }
}
