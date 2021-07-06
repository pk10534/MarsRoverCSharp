﻿using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        public Message(string name)
        {
           this.Name = name;
        }

        public Message(string name, Command[] commands)
        {
            this.Name = name;
            this.Commands = commands;
        }

     





        // Command[] commands












    }
}
