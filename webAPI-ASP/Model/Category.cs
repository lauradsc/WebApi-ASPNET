namespace webAPI_ASP.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //many-to-many relationships
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
