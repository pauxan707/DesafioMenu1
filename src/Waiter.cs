using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter

    {
        public string Name
        {
            get;
            set;
        }
        
        private List<Table> assignedTables = new List<Table>();

        public void assignTable(Table table)
        {
            this.assignedTables.Add(table);
        }
        
        public void TakeOrder(Table table, Dish dish)
        {
            if (!assignedTables.Contains(table))
            {
                throw new InvalidOperationException($"La mesa no está asignada al mozo {Name}");
            }
        
            // Agregar el platillo a la orden de la mesa
            table.AddToOrder(dish);

        }











    }


}