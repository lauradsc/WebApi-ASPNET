namespace webAPI_ASP.Model
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //ICollection is a list, but can't be edited
        public ICollection<Review> Reviews { get; set; }
    }
}
