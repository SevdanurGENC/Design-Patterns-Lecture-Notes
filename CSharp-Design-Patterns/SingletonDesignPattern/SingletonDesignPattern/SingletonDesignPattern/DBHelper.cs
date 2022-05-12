using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.SingletonDesignPattern
{
    public class DBHelper
    {
        private DBHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
               
        private static DBHelper _helper;

        public static DBHelper CreateDBHelper(string connectionString)
        {
            if (_helper == null)
            {
                _helper = new DBHelper(connectionString);
            }
            return _helper;
        }

        public string StateMessage { get; set; }

    }
}
