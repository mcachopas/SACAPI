using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacAPI.Data
{
    public class DadosBanco : IDisposable
    {
        public readonly MySqlConnection Connection;
        public MySqlCommand Command;

        public DadosBanco()
        {
            Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=mysqltest;password=Password123;database=mysqldb;");
        }

        public void Dispose()
        {
            
        }    
    }
}
