using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public string Name { get; set; }

        public Waiter(string name)
        {
            Name = name;
        }
        
        private List<Table> _assignedTables = new List<Table>();
        
        public void AssignTable(Table table)
        {
            this._assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}