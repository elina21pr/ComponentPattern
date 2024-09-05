using System;
using System.Collections.Generic;

namespace CompositePattern
{


    public abstract class BaseComposite : IComponent
    {
        private string _name;
        private List<IComponent> _components = new List<IComponent>();

        public BaseComposite(string name)
        {
            _name = name;
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            _components.Remove(component);
        }

        public double GetPrice()
        {
            double totalprice = 0;
            foreach (var component in _components)
            {
                totalprice += component.GetPrice();
            }
            return totalprice;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {_name}, Price: {GetPrice()}");

            foreach (var component in _components)
            {
                component.DisplayInfo();
            }
        }
    }
}
