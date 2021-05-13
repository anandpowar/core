namespace RecipeApi.Models
{
    public class TagModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => this.Name;
    }
}