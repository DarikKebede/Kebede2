/***********************************************************************
*** NAME: Darik Kebede                                              ****
*** CLASS: CSc 346                                                  ****
*** ASSIGNMENT: 2                                                   ****
*** DUE DATE: 02/26/2024                                            ****
*** INSTRUCTOR: GAMRADT                                             ****
*** DESCRIPTION: This program creates a user-defined Abstract Data Type (ADT) 
using C# classes named Viking and Global along with an interface named IView 
and an appropriate set of C# files                                     ***/

using System;
using System.Linq;
using System.Collections.Generic;

namespace VikingNS
{
    /*** DESCRIPTION : The global data type information use by other solution/project components ***/
    public static class Global 
    {
        public enum Status {JARL, KARL, THRAL}
        public enum Weapon {AXE, SWORD}
    }
}