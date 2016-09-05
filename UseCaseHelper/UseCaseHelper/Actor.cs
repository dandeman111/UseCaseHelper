using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Actor
    {
        public String Name { get; set; }
        public int Width { get; }
        public int Height { get; }
        public int X { get; }
        public int Y { get; }

        public Actor(String name, int x, int y)
        {
            Name = name;
            Width = 40;
            Height = 60;
            X = x;
            Y = y;
            
        }
        
    }
}
