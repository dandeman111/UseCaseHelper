﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class UseCase
    {
        public String Naam { get; set; }
        public String Samenvatting { get; set; }
        public List<Actor> Actors { get; set; }
        public String Beschrijving { get; set; }
        public String Uitzondering { get; set; }
        public String Resultaat { get; set; }
        public int Width { get; }
        public int Height { get; }
        public int X { get; }
        public int Y { get; }

        public UseCase(String naam, String samenvatting, List<Actor> actors, String beschrijving, String uitzondering, String resultaat , int x , int y)
        {
            Naam = naam;
            Samenvatting = samenvatting;
            Actors = actors;
            Beschrijving = beschrijving;
            Uitzondering = uitzondering;
            Resultaat = resultaat;
            X = x;
            Y = y;
            Width = 100;
            Height = 100;
        }
    }
}
