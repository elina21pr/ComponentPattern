
using CompositePattern.Components;
using CompositePattern;

public class Program 
{
    static void Main(string[] args)
    {
        Engine engine = new Engine("V8 Engine", 7000);

        Window window1 = new Window("Left Window", 1000);
        Window window2 = new Window("Right Window", 1000);

        Door door1 = new Door("Left Window", 8000);
        Door door2 = new Door("Right Window", 8000);

        BodyCar bodycar = new BodyCar("Lambborgini ");

        bodycar.AddComponent(door1);
        bodycar.AddComponent(door2);

        Car car = new Car("Sportcar");

        car.AddComponent(engine);
        car.AddComponent(window1);
        car.AddComponent(window2);
        car.AddComponent(bodycar);
        car.AddComponent(door1);
        car.AddComponent(door2);

        car.DisplayInfo();

        

    }
}