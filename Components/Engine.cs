namespace CompositePattern.Components
{
    public class Engine : IComponent
    {
        private string _name;
        private double _price;

        public Engine(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Engine: {_name}, Price: {_price}");
           
        }
    }
}
