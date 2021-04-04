using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>(); // one to many relationship
        public List<Battle> Battles { get; set; } = new List<Battle>(); // many to many relationship
        public Horse Horse { get; set; } // one to one relationship
    }
}
