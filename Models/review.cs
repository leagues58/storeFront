namespace StoreFront.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public bool ContactMe { get; set; }
    }
}
