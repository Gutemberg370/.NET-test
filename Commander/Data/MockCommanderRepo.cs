using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo: ICommanderRepo{
        public IEnumerable<Command> GetAppCommands(){

        }

        public Command GetCommandById (int id){
            return new Command(id = 0, HowTo = "Boil an egg", Line='Boil water', Platform = 'Kettle & Pan');
        }
    }
}