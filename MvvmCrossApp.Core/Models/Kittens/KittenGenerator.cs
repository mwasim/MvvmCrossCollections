using System;
using System.Collections.Generic;

namespace MvvmCrossApp.Core.Models.Kittens
{
    public class KittenGenerator : AnimalGenerator
    {
        private readonly List<string> _typesOfKittens = new List<string>
        {
            "Fluffy",
            "ReallyFluffy",
            "Scrappy",
            "Cute",
            "Aggressive",
            "Funny",
            "Bald",
            "WillBite",
            "HasBigPaws"
        };

        private readonly List<string> _names = new List<string>
        {
            "Tiddles",
            "Amazon",
            "Pepsi",
            "Solomon",
            "Butler",
            "Snoopy",
            "Harry",
            "Holly",
            "Paws",
            "Polly",
            "Dixie",
            "Fern",
            "Cousteau",
            "Frankenstein",
            "Bazooka",
            "Casanova",
            "Fudge",
            "Comet" };

        private readonly Random _random = new Random();

        public Kitten CreateNewKitten()
        {
            return new Kitten()
            {
                Name = _names[Random(_names.Count)],
                ImageUrl = string.Format("http://placekitten.com/{0}/{0}", _random.Next(20) + 300),
                LitterTrained = RandomBool()
            };
        }

        public KittenGroup CreateNewKittenGroup(int numberOfKittens)
        {
            var kittenList = new List<Kitten>();
            for (int x = 0; x < numberOfKittens; x++)
            {
                kittenList.Add(CreateNewKitten());
            }

            return new KittenGroup(kittenList)
            {
                Title = _typesOfKittens[_random.Next(_typesOfKittens.Count)]
            };
        }
    }
}
