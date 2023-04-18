using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IOCtest
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User(new OracleDataBase());
            user.Add("data");
            Console.Read();
         
        }
    }

    interface IDatabase
    {
        void Persist(string message);
    }
    class User
    {
        IDatabase _database;
        public User(IDatabase database)
        {
            _database = database;
        }

        public void Add(string message)
        {
            _database.Persist(message);
        }
    }

    class SqlDataBase : IDatabase
    {
        public string _message;
        void IDatabase.Persist(string message)
        {
            _message = message;
            Console.WriteLine("Sql has some " + message);
        }

    }
    public class OracleDataBase : IDatabase
    {
        public string _message;
        void IDatabase.Persist(string message)
        {
            _message = message;
            Console.WriteLine("oracle has some " + message);
        }


    }

   
}


