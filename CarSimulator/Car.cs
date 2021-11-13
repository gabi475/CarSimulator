using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator

{
    public class Car
    {
        public Car(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
        public int X { get; set; }
        public int Y { get; set; } // current x,y position of the car
        public char Direction { get; set; } // N/E/S/W

        public Room CurrentRoom { get; set; }

        public void RunCommandsForRoom(String commands, Room room)
        {
            CurrentRoom = room;
            try
            {
                foreach (char command in commands)
                {
                    switch (command)
                    {
                        case 'F':
                            Forward();
                            break;
                        case 'B':
                            Backward();
                            break;
                        case 'L':
                            SteerLeft();
                            break;
                        case 'R':
                            SteerRight();
                            break;
                    }
                }
            }
            catch (CrashException e)
            {
                Console.WriteLine("The simulation was unsuccessful!");
                throw e;
            }

        }
        // the functions for moving the car
        public void Forward()
        {
            switch (Direction)
            {
                case 'S':
                    Y++;
                    if (Y > CurrentRoom.Width)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'N':
                    Y--;
                    if (Y < 1)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'E':
                    X++;
                    if (X > CurrentRoom.Height)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'W':
                    X--;
                    if (X < 1)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
            }
        }
        public void Backward()
        {
            switch (Direction)
            {
                case 'S':
                    Y--;
                    if (Y < 1)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'N':
                    Y++;
                    if (Y > CurrentRoom.Width)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'E':
                    X--;
                    if (X < 1)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
                case 'W':
                    X++;
                    if (X > CurrentRoom.Height)
                    {
                        throw new CrashException(X, Y, Direction);
                    }
                    break;
            }
        }
        public void SteerLeft()
        {
            switch (Direction)
            {
                case 'S':
                    Direction = 'E';
                    break;
                case 'N':
                    Direction = 'W';
                    break;
                case 'E':
                    Direction = 'N';
                    break;
                case 'W':
                    Direction = 'S';
                    break;
            }
        }
        public void SteerRight()
        {
            switch (Direction)
            {
                case 'S':
                    Direction = 'W';
                    break;
                case 'N':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'S';
                    break;
                case 'W':
                    Direction = 'N';
                    break;
            }
        }
    }

}
