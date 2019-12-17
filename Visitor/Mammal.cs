namespace Visitor
 {
     public class Mammal : Animal
     {
         public Mammal(double price, bool isHealthy) : base(price, isHealthy, "ssak")
         {
         }

         public override void Accept(Visitor v)
         {
             v.VisitAnimal(this);
         }
     }
 }