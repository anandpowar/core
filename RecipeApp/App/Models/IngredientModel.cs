namespace RecipeApi.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => this.Name;
    }
}