﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishLibary
{
    internal class Player : CardPlayer
    {
        public Player(string name) : base(name) { Name = name; }


        public override void Decsion(bool isMyTurn, string cardSeeking = null, string fishFrom = null)
        {
            while (true)
            {
                if (isMyTurn)
                {
                    Console.WriteLine(Name + " turn");
                    foreach (KeyValuePair<string, int> card in _cards)
                    {
                        Console.WriteLine(card + " ");
                    }
                    Console.WriteLine("Who to fish from:");
                    fishFrom = Console.ReadLine();
                    if (!Globals.CardPlayerNames.Contains(fishFrom))
                    {
                        throw new CardPlayerDoesNotExsist("Error " + Name);
                    }
                    Console.WriteLine("What card to fish:");
                    cardSeeking = Console.ReadLine();
                    if (!_cards.ContainsKey(cardSeeking))
                    {
                        throw new CardPlayerDoesNotHaveCardType("Error " + Name);
                    }
                }
                break;
            }
            base.Decsion(isMyTurn, cardSeeking, fishFrom);
        }
    }
}
