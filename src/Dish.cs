namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish //clase
    {
        //atributos
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        
        //met constructor objeto 
        public Dish(string name, decimal price, bool isVegetarian)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
        }
        
        //met para mostrar la info del platillo
        public void MostrarInfo()
        {
            Console.WriteLine($"Platillo: {Name}");
            Console.WriteLine($"Precio: {Price}");
            Console.WriteLine($"Es Vegetariano?: {IsVegetarian}");
        }
    }
} 
