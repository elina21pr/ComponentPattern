﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Components
{
    public class Door : IComponent
    {
        private string _name;
        private double _price;

        public Door(string name, double price)
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
