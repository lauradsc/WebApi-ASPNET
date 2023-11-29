namespace webAPI_ASP.Model
{
    public class Review
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
