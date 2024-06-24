using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CommandApi.Models;
using System.Linq;
using System;

namespace CommandApi.Data
{
    public class SqlCommandApiRepo : ICommandApiRepo
    {
        private readonly CommandApiContext _context;

        public SqlCommandApiRepo(CommandApiContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {                 
            return _context.Commands.ToList();
        }

        public Command GetCommandByID(long id)
        {
            return _context.Commands.First(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}