//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // Train t1 = new Train("Last Train To London");
            // Train t2 = new Train("Last Train To London");
            // Train t3 = new Train("Runaway Train");     
            Train t1 = new Train("t1");
            t1.OneHundredTrains();   
            //t1.TenMillionTrains();
            
            //Por mas que tenga el mismo nombre del objeto, no identico, por lo que, al comparar, va a dar False.
            // Console.WriteLine(t1==t2);
            // Console.WriteLine(t2==t3);
        }
    }
}