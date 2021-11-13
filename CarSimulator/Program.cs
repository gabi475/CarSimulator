using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSimulator simulator = new CarSimulator();
            simulator.GetInput();
            simulator.RunSimulation();
        }
    }
}
