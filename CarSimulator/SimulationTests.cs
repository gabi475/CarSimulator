using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSimulator;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSimulator
{
    //[TestClass]
    public class SimpleSimulationTests
    {
        [TestMethod]
        public void TestSimulation1()
        {
            // successful input
            Car car = new Car(2, 3, 'E');
            Room room = new Room(4, 5);
            String commands = "FFL";

            CarSimulator simulator = new CarSimulator(car, room, commands);
            simulator.RunSimulation();

        }
        [TestMethod]
        public void TesSimulation2()
        {
            // successful input
            Car car = new Car(2, 3, 'E');
            Room room = new Room(4, 5);
            String commands = "BBL";

            CarSimulator simulator = new CarSimulator(car, room, commands);
            simulator.RunSimulation();

        }
    }
}

