//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void consolePrinter(Recipe recipe)
        {
            {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' usando '{step.Equipment.Description}' durante {step.Time} minutos");
            }


            Console.WriteLine($"\nCosto total de producción: ${recipe.CalculateTotalProductionCost()}");
        }
    }
}
}