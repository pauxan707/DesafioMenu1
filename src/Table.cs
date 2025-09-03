using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number { get; set; }

        public Table(int number)
        {
            Number = number;
        }
        
        private List<Dish> _order = new List<Dish>();
        public bool IsOccupied { get; set; }
        public bool HasOrders()
        {
            return this._order.Count > 0;
        }

        public void ShowOrder(Table table)
        {
            Console.WriteLine(table._order);
        }
        public void AddToOrder(Dish dish)
        {
            this._order.Add(dish);
        }
        public void Ocupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this._order.Clear();
        }
    }
}