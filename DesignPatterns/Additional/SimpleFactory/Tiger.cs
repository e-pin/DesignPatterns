﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Additional.SimpleFactory
{
    public class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The tiger says: ROAR! I prefer hunting");
        }
    }
}
