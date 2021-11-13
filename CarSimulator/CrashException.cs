using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator

{
    class CrashException : Exception
    {

        public int X { get; set; } // X and Y are the position at which the car hit the wall
        public int Y { get; set; }
        public char Direction { get; set; }
        public string CrashMessage { get; set; }

        private static string CreateCrashMessage(int x, int y, char direction)
        {
            // in functie de x, y si direction spune cum s-a lovit in perete
            switch (direction)
            {
                case 'N':
                    return $"The car crashed because it hit the North wall at position ({x},{y})";
                    break;
                case 'S':
                    return $"The car crashed because it hit the South wall at position ({x},{y})";
                    break;
                case 'W':
                    return $"The car crashed because it hit the West wall at position ({x},{y})";
                    break;
                case 'E':
                    return $"The car crashed because it hit the East wall at position ({x},{y})";
                    break;
                default:
                    return "";
            }
        }
        public CrashException(int x, int y, char direction)
            : base(
                CreateCrashMessage(x, y, direction)
             )
        {
            X = x;
            Y = y;
            Direction = direction;
            CrashMessage = CreateCrashMessage(x, y, direction);
        }
    }

}
