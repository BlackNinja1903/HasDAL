using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasDAL.Utility
{
    class MsSqlDAL:IDal
    {
        string _name = "MsSql";

        public MsSqlDAL() { }

        public override void ExecuteNonQuery(string sql, System.Collections.IEnumerable parameters)
        {
            Console.WriteLine(_name + "\nExecuteNonQuery Executed");    
        }

        public override int ExecuteScalar(string sql, System.Collections.IEnumerable parameters)
        {
            Console.WriteLine(_name + "\nExecuteScalar Executed");
            return 0;
        }

        public override DataTable ExecuteDataTable(string sql, System.Collections.IEnumerable parameters)
        {
            Console.WriteLine(_name + "\nExecuteDataTable Executed");
            return null;
        }

        public override IDataReader ExecuteDataReader(string sql, System.Collections.IEnumerable parameters)
        {
            Console.WriteLine(_name + "\nExecuteDataReader Executed");
            return null;
        }
    }
}
