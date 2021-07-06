using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Message message1;
        string testName;
        Command[] commands = new Command[] 
        { 
            new Command(), 
            new Command()
        };
       // Command[] commands1 = { new Command("foo", 0), new Command("bar", 20) };
        
        [TestInitialize]
        public void CreateInstances()
        {
            message1 = new Message(testName, commands);
            testName = "Message";
        }

        [TestMethod] //5
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message Name required.", ex.Message);
            }
        }


        // TEST NUMBER 6


        [TestMethod] //6
        public void ConstructorSetsName()
        {
            string testName = "Message 1";
            Message message1 = new Message(testName);
            Assert.AreEqual(testName, message1.Name);
            /*
            Message newMessage = new Message("Test message with two commands");
            Assert.AreEqual(newMessage.Name, "Test message with two commands");
            */
        }

        // TEST NUMBER 7 

        //Need to iterate over array to get access to each index stored inside of it. This can be done with a foreach or for loop
        // 1. Create new object
        // 2. Pass in new data
        // 3. Access the array
        // 4. Iterate over array
        // 5. Check if values match (are equal)
        // 6. Does command property store an array: check command properties or command instance properties?

        
        
        [TestMethod] //7
        public void ConstructorSetsCommandsField()
        {
            string testName = "Message";
            Command[] commands = new Command[]
            {
                new Command("MODE CHANGE", "LOW POWER"),
                new Command("MOVE", 500) 
            };
            Message message1 = new Message(testName, commands);

            Assert.AreEqual(message1.Commands, commands);

            //foreach(Command item in message1.Commands)
            //{

            //}

        }
       








        


    }
}
