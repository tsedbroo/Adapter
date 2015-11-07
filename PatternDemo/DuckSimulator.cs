using System;
using System.Collections.Generic;
using System.Linq;

using OtherProgrammersCode;

namespace PatternDemo
{
    public class DuckSimulator
    {  
        static void Main(string[] args)
        {
           // multiple other developers depend on the DuckFactory --  don't change the DuckFactory or else

            List<IQuackable> myDucks = new DuckFactory().FactoryGameSpecs();// ask factory for ducks
           
        //****  Adapter Pattern **********  Homework  *************************************  
         

            // Homework Problem: You want to use a IHonker in your game -  figure out a how to include an IHonker in your game
         
            // *************hint: once you have a HonkerAdapter you can uncomment the three line of code below
          
            //  IHonkable honker = HonkerFactory.getAHonker();
            //  Console.WriteLine("Duck Simulator: With Honker Adapter");
            //  IQuackable HonkerAdaptedAsDuck = new HonkerAdapter(honker);
           //   myDucks.Add(HonkerAdaptedAsDuck);

           
       //**********************************************************    

            DuckSimulator.Simulate(myDucks); // play the game
             // Wait for user entry
            Console.ReadKey();
        }


       // multiple other developers depend on the static method shown below
       //  if you change it you break all of their code 
        static void Simulate(List<IQuackable> ducks)
        {
            ducks.ForEach(duck => duck.Quack());
        }


    }

}






































           