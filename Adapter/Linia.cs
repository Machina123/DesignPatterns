using System;
 
 namespace Adapter
 {
     public class Linia : Figura
     {
         
         public void Wyswietl()
         {
             Console.WriteLine("Rysuje linie");
         }
 
         public void Wypelnij()
         {
             throw new NotImplementedException();
         }
 
         public void Usun()
         {
             throw new NotImplementedException();
         }
     }
 }