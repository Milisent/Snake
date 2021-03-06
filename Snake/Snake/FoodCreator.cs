﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char symb;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symb)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
