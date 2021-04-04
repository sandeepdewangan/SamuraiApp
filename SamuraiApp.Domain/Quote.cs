namespace SamuraiApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // Foreign Key to Samurai
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}
