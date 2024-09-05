using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompositePattern.Components
{
    public class Window : IComponent
    {
        private string _name;
        private double _price;

        public Window(string name, double price)
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
            Console.WriteLine($"Window: {_name}, Price: {_price}");
            
        }
    }
}

