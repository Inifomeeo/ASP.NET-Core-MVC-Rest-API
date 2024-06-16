using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CommandApi.Models;

namespace CommandApi.Data
{
    public class MockCommandApiRepo : ICommandApiRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Walk dog", Line="Go outside", Platform="Outdoors"},
                new Command{Id=1, HowTo="Cut fish", Line="Get knife", Platform="Chopping board"},
                new Command{Id=2, HowTo="Eat food", Line="Heat up food", Platform="Microwave"}
            };
            
            return commands;
        }

        public Command GetCommandByID(long id)
        {
            return new Command{Id=0, HowTo="Walk dog", Line="Go outside", Platform="Outdoors"};
        }
    }
}