using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    public interface IDatabase
    {
        void Post();
        void Get();
        void Put();
        void Delete();
    }

    public class MySql : IDatabase
    {
        public void Post() => Console.WriteLine("Post [MySql]");
        public void Get() => Console.WriteLine("Get [MySql]");
        public void Put() => Console.WriteLine("Put [MySql]");
        public void Delete() => Console.WriteLine("Delete [MySql]");
    }

    public class MSSql : IDatabase
    {
        public void Post() => Console.WriteLine("Post [MSSql]");
        public void Get() => Console.WriteLine("Get [MSSql]");
        public void Put() => Console.WriteLine("Put [MSSql]");
        public void Delete() => Console.WriteLine("Delete [MSSql]");
    }

    public class Oracle : IDatabase
    {
        public void Post() => Console.WriteLine("Post [Oracle]");
        public void Get() => Console.WriteLine("Get [Oracle]");
        public void Put() => Console.WriteLine("Put [Oracle]");
        public void Delete() => Console.WriteLine("Delete [Oracle]");
    }

    public class PostgreSQL : IDatabase
    {
        public void Post() => Console.WriteLine("Post [PostgreSQL]");
        public void Get() => Console.WriteLine("Get [PostgreSQL]");
        public void Put() => Console.WriteLine("Put [PostgreSQL]");
        public void Delete() => Console.WriteLine("Delete [PostgreSQL]");
    }

    public class MongoDB : IDatabase
    {
        public void Post() => Console.WriteLine("Post [MongoDB]");
        public void Get() => Console.WriteLine("Get [MongoDB]");
        public void Put() => Console.WriteLine("Put [MongoDB]");
        public void Delete() => Console.WriteLine("Delete [MongoDB]");
    }

    public class Strategy
    {
        public void Execute(int provider)
        {
            IDatabase database;

            switch (provider)
            {
                case 1:
                    database = new MySql();
                    break;
                case 2:
                    database = new MSSql();
                    break;
                case 3:
                    database = new Oracle();
                    break;
                case 4:
                    database = new PostgreSQL();
                    break;
                case 5:
                    database = new MongoDB();
                    break;
                default:
                    throw new ArgumentException("Invalid provider.");
            }

            database.Post();
            database.Get();
            database.Put();
            database.Delete();
        }
    }
}
