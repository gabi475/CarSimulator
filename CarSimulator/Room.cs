using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CarSimulator
{
    public class Room
    {
        public Room(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; set; }// from W to E
        public int Height { get; set; } // from N to S
    }

}