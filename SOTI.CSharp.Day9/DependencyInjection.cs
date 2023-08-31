using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day9
{
    public interface IDALRepository
    {
        void GetProducts();

        void GetProductById(int id);
    }

    public class SQLServerDAL : IDALRepository
    {
        public void GetProductById(int id)
        {
            Console.WriteLine("Product Id from SQL Server:" + id);
        }

        public void GetProducts()
        {
            Console.WriteLine("Sql Server Products");
        }
    }

    public class OracleDAL : IDALRepository
    {
        public void GetProducts()
        {
            Console.WriteLine("Oracle Products");
        }

        public void GetProductById(int id)
        {
            Console.WriteLine("Product Id from Oracle:" + id);
        }
    }

    public class BusinessLayer
    {
        private readonly IDALRepository _repository = null;
      
        //Constructor Injection
        public BusinessLayer(IDALRepository repository)
        {
            _repository = repository;
        }

        //Method Injection
        public void GetProducts()
        {
            _repository.GetProducts();
            //your validation code goes here
        }

        public void GetProductById(int id)
        {
            _repository.GetProductById(id);
        }

        static void Main(string[] args)
        {
            BusinessLayer obj = new BusinessLayer(new SQLServerDAL());
            obj.GetProducts();
            obj.GetProductById(1001);
        }
    }
}
