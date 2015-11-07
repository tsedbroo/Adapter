using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternDemo
{
    //Factory pattern deals with the instantiation of object without exposing the instantiation logic. 
    // In other words, a Factory is actually a creator of objects which have common interface.
    public enum DuckType
    {
        DUCKCALLL,
        DECOY_DUCK,
        MALLARD_DUCK,
        RUBBER_DUCK,
        REDHEAD_DUCK,
    }
    public class DuckFactory
    {
        private Dictionary<DuckType, IQuackable> DuckDictionary = new Dictionary<DuckType, IQuackable>();

        public DuckFactory()
        {   // the dictionary contains everything the factory knows how to build
            DuckDictionary.Add(DuckType.DUCKCALLL, new DuckCall());
            DuckDictionary.Add(DuckType.DECOY_DUCK, new DecoyDuck());
            DuckDictionary.Add(DuckType.MALLARD_DUCK, new MallardDuck());
            DuckDictionary.Add(DuckType.REDHEAD_DUCK, new RedheadDuck());
            DuckDictionary.Add(DuckType.RUBBER_DUCK, new RubberDuck());
        }

        public List<IQuackable> FactoryGameSpecs(){
            List<DuckType> DuckGameSpec = new List<DuckType>
                                           { DuckType.DECOY_DUCK,DuckType.DECOY_DUCK,DuckType.DUCKCALLL,DuckType.MALLARD_DUCK,
                                             DuckType.REDHEAD_DUCK,DuckType.RUBBER_DUCK};

       
            List<IQuackable> MyDucks = new List<IQuackable>();
           
            DuckGameSpec.ForEach(Dspec => MyDucks.Add(getDuck(Dspec)));
            return MyDucks;
            }

       
       public IQuackable getDuck(DuckType duckType)
        {
            if (DuckDictionary.ContainsKey(duckType))
            {
                return DuckDictionary[duckType];
            }
            else return null;
        }
    }
}
