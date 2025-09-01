using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> _dishes = new List<Dish>();

        public void AddDish(Dish newDish)
        {
            _dishes.Add(newDish);

        }

        public void RemoveDish(Dish dish)
        {
            if (_dishes.Contains(dish))
            {
                _dishes.Remove(dish);
            }
            else
            {
                Console.WriteLine("El plato no se encuentra en el menu");
            }
        }

        public string PresentDish(Dish dish)
        {
            Console.WriteLine($"El plato {dish.Name}, de ${dish.Price}, {dish.IsVegetarian}");
            
            return $"El plato {dish.Name}, de ${dish.Price}, {dish.IsVegetarian}";
        }


    }
}