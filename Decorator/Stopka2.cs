using System;
 
 namespace Decorator
 {
     public class Stopka2 : Dekorator
     {
         public Stopka2(Komponent mojKomponent) : base(mojKomponent)
         {
         }
 
         public override void Drukuj()
         {
             base.Drukuj();
             Console.WriteLine("Stopka 2");
         }
     }
 }