using System.Collections.Generic;
using FooBar.Models;

namespace FooBar.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Lorem lipsum", Line="Boil water", Platform="Kettels and Pans"},
                new Command{Id=1, HowTo="Educate Childere", Line="Boil water", Platform="Kettels and Pans"},
                new Command{Id=2, HowTo="Makea cup of tea", Line="Boil water", Platform="Kettels and Pans"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Lorem lipsum", Line="Boil water", Platform="Kettels and Pans"};
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}