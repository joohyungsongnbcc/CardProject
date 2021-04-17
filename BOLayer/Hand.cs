using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{

        public class Hand
        {
            private List<Card> cards = new List<Card>();

            public Card this[int index]
            {
                get
                {
                    return cards[index];
                }
            }

            public int Count
            {
                get
                {
                    return cards.Count();
                }
            }

            public void AddCard(Card newCard)
            {


                if (ContainsCard(newCard))
                {
                    throw new ConstraintException($"{newCard.FaceValue} of {newCard.Suit} already" +
                        $"exists in the Hand");
                }
                cards.Add(newCard);
            }

            private bool ContainsCard(Card cardToCheck)
            {
                /*bool exists = false;
                foreach(Card card in cards)
                {
                    if (card.FaceValue == cardToCheck.FaceValue && card.Suit == cardToCheck.Suit)
                    {
                        exists = true;

                    }

                }
                return exists;*/

                return cards.Where(card => card.FaceValue == cardToCheck.FaceValue
                                        && card.Suit == cardToCheck.Suit).Count() != 0;
            }

        }
    }

