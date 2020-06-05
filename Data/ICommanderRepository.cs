
using FooBar.Models;
using System.Collections.Generic;

namespace FooBar.Data
{
    public interface ICommanderRepository
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}