﻿using System;

namespace OOP
{
    class Program
    {  
        static void Main(string[] args)
        {
            Quad fred = new Rect();
            Console.WriteLine($"Fres is a {fred.WhatAmI()}");


            var sqr1 = new Sqr(4);
            Console.WriteLine($"The Perimeter of the sqr is {sqr1.Perimeter()}");
            Console.WriteLine($"The Area of the sqr is {sqr1.Area()}");
            Console.WriteLine($"The sqr is a {sqr1.WhatAmI()}");

            var rect1 = new Rect(5, 3);
            Console.WriteLine($"The Perimeter of the rect is {rect1.Perimeter()}");
            Console.WriteLine($"The Area of the rect is {rect1.Area()}");
            Console.WriteLine($"The rect1 is a {rect1.WhatAmI()}");


            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"The Perimeter of the quad is {quad1.Perimeter()}");

            var collection = new Quad[]
            {
                fred, sqr1, rect1, quad1
            };
            foreach(var geo in collection)
            {
                Console.WriteLine($"geo is a {geo.WhatAmI()}");
                var rect = geo as Rect;
                if(rect != null)
                {
                    Console.WriteLine($"The area of geo is {rect.Area()}");
                }
            }
            

            

        }
    }
}
           
