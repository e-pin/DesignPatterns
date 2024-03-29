﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.V1
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {
            
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        

        public override void Print()
        {
            Console.WriteLine("Book Print");
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
