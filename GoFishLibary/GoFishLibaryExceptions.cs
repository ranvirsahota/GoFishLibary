using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishLibary
{
    internal class GoFishExceptions : System.Exception
    {
        internal GoFishExceptions() { }
        internal GoFishExceptions(string message) : base(message) { }
    }
    internal class CardPlayerDoesNotHaveCardType : GoFishExceptions
    {
        internal CardPlayerDoesNotHaveCardType() { }
        internal CardPlayerDoesNotHaveCardType(string message) : base(message) { }
    }
    internal class PlayerFishingHasNotSpecifedCardToFish : GoFishExceptions
    {
        internal PlayerFishingHasNotSpecifedCardToFish() { }
        internal PlayerFishingHasNotSpecifedCardToFish(string message) : base(message) { }
    }
    internal class CardPlayerDoesNotExsist : GoFishExceptions
    {
        internal CardPlayerDoesNotExsist() { }
        internal CardPlayerDoesNotExsist(string message) : base(message) { }
    }
}
