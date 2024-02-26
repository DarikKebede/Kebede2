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
    /*** The Viking class that describes the current state of an individual Viking class instance ***/
    public class Viking : IView
    {
        public string Name {get; set;}
        public Global.Status Status {get; set;}
        public short Health {get; set;}
        public Global.Weapon Weapon{get; set;}
        public bool Shield {get; set;}

        public Viking(Viking viking)
                {
                   Name = viking.Name;
                   Global.Status status = viking.Status;
                   Health = viking.Health;
                   Global.Weapon weapon = viking.Weapon;
                   Shield = viking.Shield;
                }
        public Viking(
            String name = "Bjorn", Global.Status status = Global.Status.KARL,
            short health = 150, Global.Weapon weapon = Global.Weapon.AXE,
            bool shield = false 
        ){
            Name = name; 
            Status = status;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }
                public void ViewH()
                {
                    Console.WriteLine("Name\tStatus\tHealth\tWeapon\tShield");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Name, Status, Health, Weapon, Shield);
                }
                public void ViewV()
                {
                    Console.WriteLine("Name:\t" + Name);
                    Console.WriteLine("Status:\t" + Status);
                    Console.WriteLine("Health:\t" + Health);
                    Console.WriteLine("Weapon:\t" + Weapon);
                    Console.WriteLine("Shield:\t" + Shield);
                }
    }
}