namespace CovarianceAndContravarianceExample
{
    abstract class Engine
    {
        
    }

    class V8Engine : Engine
    {
        
    }

    interface ICar<out T> where T : Engine
    {
        T GetEngine();
    }

    class Bmw : ICar<V8Engine>
    {
        public V8Engine GetEngine()
        {
            return new V8Engine();
        }
    }
    

    internal class Program
    {
        public static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            
            ICar<V8Engine> vEightCar = bmw;
            
            ICar<Engine> someCar = bmw;
        }
    }
}