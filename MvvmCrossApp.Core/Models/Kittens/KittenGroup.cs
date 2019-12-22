using System.Collections.Generic;

namespace MvvmCrossApp.Core.Models.Kittens
{
    public class KittenGroup : List<Kitten>
    {
        public string Title { get; set; }

        public KittenGroup(IEnumerable<Kitten> collection) : base(collection)
        {

        }
    }
}
