//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();

            recipe.FinalProduct =  Sale.GetProduct("Café con leche");
            recipe.AddStep(Sale.GetProduct("Café"), 100, Sale.GetEquipment("Cafetera"), 120);
            recipe.AddStep(Sale.GetProduct("Leche"), 200, Sale.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {

            Sale.AddProductToCatalog("Café", 100);
            Sale.AddProductToCatalog("Leche", 200);
            Sale.AddProductToCatalog("Café con leche", 300);

            Sale.AddEquipmentToCatalog("Cafetera", 1000);
            Sale.AddEquipmentToCatalog("Hervidor", 2000);
        }


    }
}
