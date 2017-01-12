using System;
using System.Collections.Generic;

namespace ConsoleApplication
{



    public class Card{

        public override string ToString(){
            return val + " " + suit;
        }

        string val;
        string suit;
        int numVal;
        public Card(string val1, string suit1, int numVal1){
            val = val1;
            suit = suit1;
            numVal = numVal1;
        }
    }


    public class Deck{

        List<object> cards = new List<object>();
        public Deck(){
            makeDeck();
        }

        private List<object> makeDeck(){
            string[] suits = {"Spades", "Diamonds", "Clubs", "Hearts"};
            string cardVal = "";
            for(int i = 0; i < suits.Length; i++){
                for(int j = 1; j <= 13; j ++){
                    if(j == 1){
                        cardVal = "A";
                    } else if(j == 11){
                        cardVal = "J";
                    } else if(j == 12){
                        cardVal = "Q";
                    } else if(j == 13){
                        cardVal = "K";
                    } else {
                        cardVal = j.ToString();
                    }
                    Card card = new Card(cardVal, suits[i], j);
                    cards.Add(card);
                }
            }
            return cards;
        }

        public void printDeck(){
            Console.WriteLine("[{0}]", string.Join(", ",cards));
        }
    }







    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck myDeck = new Deck();
            myDeck.printDeck();
        }
    }
}
