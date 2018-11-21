using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventBroker = new EventBroker();
            var person = new PersonController(eventBroker);
            
            var cnc = new ChangeNameCommand(person, "Aimal Khan");

            eventBroker.Command(cnc);


            var cnq = new AskForName(person);
            var name = eventBroker.Query<string>(cnq);
            Console.WriteLine(name);

            Console.Read();
        }
    }

    public class PersonController
    {
        private string name;
        private EventBroker eventBroker;
        
        public PersonController(EventBroker eb)
        {
            this.eventBroker = eb;
            eb.Commands += ChangeNameCommandHandler;
            eb.Queries += AskingForName;
        }

        private void AskingForName(object sender, Query e)
        {
            var query = e as AskForName;
            if (query.Person == this)
            {
                query.result = this.name;
            }
        }

        private void ChangeNameCommandHandler(object sender, Command e)
        {
            var command = e as ChangeNameCommand;
            if (command.target == this && command.newName != null)
            {
                this.name = command.newName;
            }
        }
    }

    public class EventBroker
    {
        public event EventHandler<Command> Commands;
        public event EventHandler<Query> Queries;

        public void Command(Command c)
        {
            Commands?.Invoke(this, c);
        }

        public T Query<T>(Query q)
        {
            Queries?.Invoke(this, q);
            return (T)q.result; 
        }
    }

    public class Query
    {
        public object result;
    }

    public class AskForName : Query
    {
        public PersonController Person;

        public AskForName(PersonController pc)
        {
            this.Person = pc;
        }
    }

    public class Command
    {
    }

    public class ChangeNameCommand : Command
    {
        public PersonController target;
        public string newName;

        public ChangeNameCommand(PersonController pc, String name)
        {
            this.newName = name;
            this.target = pc;
        }
    }
}