using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {

        [TestMethod] //8
        public void ConstructorSetsDefaultPosition()
        {
            int position = 98382;
            Rover newRover = new Rover(position);
            Assert.AreEqual(newRover.Position, position);
        }

        [TestMethod] //9
        public void ConstructorSetsDefaultMode()
        {
            string mode = "Normal";
            Rover newRover = new Rover(100);
            Assert.AreEqual(newRover.Mode, mode);
        }

        [TestMethod] //10
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            int generatorwatts = 110;
            Rover newRover = new Rover(generatorwatts);
            Assert.AreEqual(newRover.GeneratorWatts, generatorwatts);
        }

        [TestMethod] //11
        public void RespondsCorrectlyToModeChangeCommand()
        {
            string newMode = "LOW POWER";
            string commandType = "NEW MODE";
            Command newCommand = new Command(commandType, newMode);
            Assert.AreEqual(newCommand.CommandType, commandType);
            Assert.AreEqual(newCommand.NewMode, newMode);
        }



        /*
        [TestMethod] //12
        public void DoesNotMoveInLowPower()
        {
            string newMode = "LOW POWER";
            string commandType = "NEW MODE";
            Command newCommand = new Command(commandType, newMode);
            string commandType2 = "MOVE";
            int position = 500;
            Command newCommand2 = new Command(commandType2, position);
            Assert.AreEqual(newCommand2.NewPostion, position);
            Assert.AreEqual(newCommand.NewMode, newMode);
        }
        */
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover rover = new Rover(default)
            {
                Mode = "LOW POWER"
            };
            Command[] commands = new Command[]
            {
                new Command("MOVE", 500)
            };
            Message message = new Message("Name", commands);

            rover.ReceiveMessage(message);
            Assert.AreEqual(rover.Position, default);
        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover rover = new Rover(default);
            Command[] command = new Command[]
            {
                new Command("MOVE", 500)
            };
            Message message = new Message("Name", command);
            rover.ReceiveMessage(message);
            Assert.AreEqual(rover.Position, 500);
        }


        















    }
}
