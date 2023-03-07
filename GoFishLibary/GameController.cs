using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishLibary
{
    public abstract class GameController
    {
        //TODO: Change to generic type
        protected List<string> Cards { private set; get; }

        protected GameController() {
            Cards = new List<string>() {
                "ace", "ace", "ace", "ace",
                "two", "two", "two", "two",
                "three", "three", "three", "three",
                "four", "four", "four", "four",
                "five", "five", "five", "five",
                "six", "six", "six", "six",
                "seven", "seven", "seven", "seven",
                "eight", "eight", "eight", "eight",
                "nine", "nine", "nine", "nine",
                 "ten", "ten", "ten", "ten",
                 "jack", "jack", "jack", "jack",
                 "queen", "queen", "queen", "queen",
                 "king", "king", "king", "king"
            };
            var rnd = new Random();
            Cards = Cards.OrderBy(x => rnd.Next()).ToList<string>();
            Globals.Stack = Cards;
        }




        protected abstract void GameLoop();
        
        protected abstract void Deal();

        //To play their must be one card in either player's hand or in stack 
        public static bool ValidPlayer(CardPlayer cardPlayer) => cardPlayer.CardCount > 0 || Globals.Stack.Count > 0;

        //If player's hand empty  will be assigned a card from stack, return true/false
        public bool HandNotEmpty(CardPlayer cardPlayer)
        {
            if (cardPlayer.CardCount == 0 && Globals.Stack.Count > 0)
            {
                AssignCard(cardPlayer);
                return false;
            }
            return true;
        }

        //Adds new card to player and removes it from stack
        public void AssignCard(CardPlayer cardPlayer) {
            cardPlayer.CardsSet(Cards[0]);
            Cards.RemoveAt(0);
        }


        public static void ClearRound()
        {
            Globals.CARD_TRANSACTION.Clear();
            Globals.CARD_PLAYERS_FROM_TO_TRANSACTION[0] = null;
            Globals.CARD_PLAYERS_FROM_TO_TRANSACTION[1] = null;
        }
    }
}
