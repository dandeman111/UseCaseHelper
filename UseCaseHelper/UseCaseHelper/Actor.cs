using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Actor
    {
        public String Name { get; set; }
        public int Width { get; }
        public int Height { get; }
        public int X { get; }
        public int Y { get; }
        public override string ToString() { return Name; }

        public Actor(String name, int x, int y)
        {
            Name = name;
            Width = 50;
            Height = 110;
            X = x;
            Y = y;
            
        }
        
    }
}
