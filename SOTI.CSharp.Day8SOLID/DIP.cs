using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8SOLID
{
    public interface IRepository
    {
        void GetProducts();
    }

    public class SQLServerDAL : IRepository //Low level Module
    {
        public void GetProducts()
        {
            Console.WriteLine("Sql Server Products");
        }
    }

    public class OracleDAL : IRepository
    {
        public void GetProducts()
        {
            Console.WriteLine("Oracle Products");
        }
    }

    public class BusinessLayer //High Level Module
    {
        public void GetProducts()
        {
            IRepository objDAL = RepositoryFactory.GetRepositories();
            objDAL.GetProducts();
            //your validation code goes here
        }
    }

    public class RepositoryFactory
    {
        private static IRepository _repository = null;

        public static IRepository GetRepositories()
        {
            _repository = new OracleDAL();
            return _repository;
        }
    }
}
