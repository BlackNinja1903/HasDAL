using HasDAL.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = DalFactory.Instance;
            dal.ExecuteDataTable("TableSample", new List<string>() { "p1","p2"});

            Console.Read();
        }
    }
}
