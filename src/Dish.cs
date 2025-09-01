namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal Price { get; set; }
        
        public Dish(string name, decimal price, bool isVegetarian)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
        }
    }
}