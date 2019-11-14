using System;
 
 namespace Iterator
 {
     class Program
     {
         static void Main(string[] args)
         {
             int[] testData = {1, 2, 3, 4, 5, 6, 0, 7, 0, 0, 8, 9, 0};
             Aggregate<int> iterableArray = new SimpleAggregate<int>(testData);
             Iterator<int> iterator = iterableArray.GetIterator();
             iterator.First();
             while (!iterator.IsDone())
             {
                 Console.Write($"{iterator.CurrentItem()} ");
                 iterator.Next();
             }
             Console.WriteLine(" ");
             Aggregate<int> iterableNonZeroAggregate = new NonZeroAggregate<int>(testData);
             Iterator<int> nzIter = iterableNonZeroAggregate.GetIterator();
             nzIter.First();
             while (!nzIter.IsDone())
             {
                 try
                 {
                     Console.Write($"{nzIter.CurrentItem()} ");
                     nzIter.Next();
                 }
                 catch (InvalidOperationException)
                 {
                     // koniec kolekcji, ostatni element to 0
                 }
             }
         }
     }
 }