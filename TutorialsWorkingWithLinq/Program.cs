// tutorials: https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/working-with-linq

using System;
using System.Collections.Generic;
using System.Linq;

namespace TutorialsWorkingWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 查询语法
            var startingDeck =
                from suit in Suits()
                from rank in Ranks()
                select new {Suit = suit, Rank = rank};
            */

            /*
            // 方法语法
            var startingDeck = Suits().SelectMany(
                suit => Ranks().Select(rank => new
                {
                    Suit = suit,
                    Rank = rank,
                })
            );
            */

            var startingDeck =
                (from suit in Suits().LogQuery("Suit Generation")
                    from rank in Ranks().LogQuery("Value Generation")
                    select new {Suit = suit, Rank = rank})
                .LogQuery("Starting Deck")
                .ToArray();

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine();

            /*
            // 52 cards in a deck, so 52 / 2 = 26
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            foreach (var card in shuffle)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine();
            */

            // 比较
            var times = 0;
            var shuffle = startingDeck;

            do
            {
                /*
                shuffle = shuffle.Skip(26).InterleaveSequenceWith(shuffle.Take(26));
                */

                /*
                shuffle = shuffle.Take(26)
                    .LogQuery("Top Half")
                    .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
                    .LogQuery("Shuffle")
                    .ToArray();
                */

                shuffle = shuffle
                    .Skip(26)
                    .LogQuery("Bottom Half")
                    .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
                    .LogQuery("Shuffle")
                    .ToArray();

                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }

                times++;
                Console.WriteLine(times);
            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);
        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}