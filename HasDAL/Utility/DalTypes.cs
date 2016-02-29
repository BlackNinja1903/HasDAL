using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasDAL
{
    internal enum DalTypes:byte
    {
        Oracle=0,
        MsSql=1,
        MySql=2,
        NoSql=3
    }
}
