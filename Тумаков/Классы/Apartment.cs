﻿
namespace Тумаков
{
    enum Color
    {
        черный = 1, 
        белый = 2,
        синий = 3, 
        зеленый = 4
    }
    internal class Apartment
    {
        internal static int number;
        internal uint height;
        internal uint floor;
        internal double heig_floor;
        internal Color color;
        internal Apartment(uint height, uint floor, Color color)
        {
            this.height = height;
            this.floor = floor;
            this.color = color;
        }
        internal Apartment(uint height, uint floor)
        {
            this.height = height;
            this.floor = floor;
        }
    }
}
