using System;


namespace OtherProgrammersCode
{
    // this is an existing class from a cranky programmer who won't let you change or even view his code.
    // you just have access to the static method getAHonker() that returns a IHonkable

    public interface IHonkable
    {
        void Honk();
    }
    class HonkerFactory {  
        private  class Goose:IHonkable
                 {
                   public void Honk()
                      {
                             Console.WriteLine("Honk");
                      }
   
                }

  public static IHonkable getAHonker()
        {
           // ok here is a goose
            return new Goose();
        }
  }
}
    


