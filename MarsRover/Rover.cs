using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }
        

        public Rover (int position)
        {
            Position = position;
            Mode = "Normal"; 
            GeneratorWatts = 110;
        }

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }



        public void ReceiveMessage(Message message)
        {
            foreach(var command in message.Commands)
            {
                if(command.CommandType == "MODE CHANGE")
                {
                    Mode = command.NewMode;
                }
                else if (command.CommandType == "MOVE" && Mode != "LOW POWER")
                {
                    Position = command.NewPostion;
                }
            }
        }




    }
}
