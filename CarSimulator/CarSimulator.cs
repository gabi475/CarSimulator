using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator

{

    public class CarSimulator
    {


        public CarSimulator()
        {
            InputCar = null;
            InputRoom = null;
            Commands = null;
        }
        public CarSimulator(Car inputCar, Room inputRoom, String commands)
        {
            InputCar = inputCar;
            InputRoom = inputRoom;
            Commands = commands;
        }

        public Car InputCar { get; set; }
        public Room InputRoom { get; set; }
        public String Commands { get; set; }
        public void GetInput()
        {
            // successful input
            int startX, startY;
            char startDirection;
            int roomSide1, roomSide2;
            String commands, input;

            do
            {
                Console.Write("Please type the car's initial x coordinate (from West to East): ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out startX));
            do
            {
                Console.Write("Please type the car's initial y coordinate (from North to South): ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out startY));

            do
            {
                Console.Write("Please type the car's direction (N/W/E/S): ");
                startDirection = Console.ReadKey().KeyChar;
                Console.WriteLine(); // end of line
            } while ("NSWE".IndexOf(startDirection) == -1);


            do
            {
                Console.Write("Please type the West to East length of the room: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out roomSide1));
            do
            {
                Console.Write("Please type the North to South length of the room: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out roomSide2));

            Console.WriteLine("Please type in the commands for the Car (L -> Steer left, R -> Steer right, F -> Forward, B -> Backward)");
            Console.WriteLine("Keep them tight, such as 'FFL'");

            commands = Console.ReadLine();

            InputCar = new Car(startX, startY, startDirection);
            InputRoom = new Room(roomSide1, roomSide2);
            Commands = commands;
        }

        public void RunSimulation()
        {
            try
            {
                InputCar.RunCommandsForRoom(Commands, InputRoom);
                // successful simulation:
                Console.WriteLine($"The simulation was succesful");
                Console.WriteLine($"The car is at {InputCar.X} {InputCar.Y} from the N-W corner, with direction {InputCar.Direction}.");
            }
            catch (CrashException e)
            {
                // the simulation went wrong
                Console.WriteLine(e.CrashMessage);
            }
            Console.ReadKey(true);
        }
    }

}

