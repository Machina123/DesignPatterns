using System;
 
 namespace AbstractFactory
 {
     class Program
     {
         static void Main(string[] args)
         {
             ApNadzorujaca nadzorcaN = new ApNadzorujaca(Konfiguracja.PobierzFabrykeNisRozdz());
             nadzorcaN.Dzialaj();
             
             ApNadzorujaca nadzorcaW = new ApNadzorujaca(Konfiguracja.PobierzFabrykeWysRozdz());
             nadzorcaW.Dzialaj();
         }
     }
 }