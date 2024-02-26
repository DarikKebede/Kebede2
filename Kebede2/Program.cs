/************************************************************************
*** NAME: Darik Kebede                                              ****
*** CLASS: CSc 346                                                  ****
*** ASSIGNMENT: 2                                                   ****
*** DUE DATE: 02/26/2024                                            ****
*** INSTRUCTOR: GAMRADT                                             ****
************************************************************************ 
*** DESCRIPTION: This program creates a user-defined Abstract Data Type (ADT) 
using C# classes named Viking and Global along with an interface named IView 
and an appropriate set of C# files                                  ***/

using System;
using System.Linq;
using System.Collections.Generic;

namespace VikingNS
{
    /*** METHOD : Console.Writeline                                             *******
     *** DESCRIPTION : Display the current state of an individual Viking Class instance 
     *** in a horizontal and vertical arrangement                                  ***/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nIView interface using a horizonatl arrangement");
            Viking vikingH = new Viking();
            vikingH.ViewH();
            vikingH.ViewV();
            Console.WriteLine("\nIView interface using a vertical arrangement");
            Viking vikingV = new Viking("Ragner", Global.Status.JARL, 250, Global.Weapon.SWORD, true);
            vikingV.ViewH();
            vikingV.ViewV();
        }
    }
} 
