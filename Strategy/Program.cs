using Decorater;

namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
       MallardDuck duck = new MallardDuck(); 
       
       duck.Display();
       duck.PerformFly();
       duck.PerformQuack();
       
       ModelDuck modelDuck = new ModelDuck();
       modelDuck.PerformFly();

       modelDuck.SetFlyBehavior(new FlyWithWings());
       
       modelDuck.PerformFly();
    }
}