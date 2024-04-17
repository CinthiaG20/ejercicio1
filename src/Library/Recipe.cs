//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        
          public double CalculateTotalProductionCost()
        {
            double ingredientCost = 0;
            double equipmentCost = 0;

            foreach (Step step in this.steps)
            {
                ingredientCost += step.Input.UnitCost * step.Quantity;
                equipmentCost += step.Equipment.HourlyCost * step.Time;
            }

            return ingredientCost + equipmentCost;
        }
        public void PrintRecipe()
        {
            {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' usando '{step.Equipment.Description}' durante {step.Time} minutos");
            }


            Console.WriteLine($"\nCosto total de producción: ${this.CalculateTotalProductionCost()}");
        }
    }
}
}