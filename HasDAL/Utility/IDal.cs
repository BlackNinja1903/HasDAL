using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasDAL
{
    public abstract class IDal
    {
        public IDal() { }
        public abstract void ExecuteNonQuery(string sql,IEnumerable parameters);
        public abstract int ExecuteScalar(string sql, IEnumerable parameters);
        public abstract DataTable ExecuteDataTable(string sql, IEnumerable parameters);
        public abstract IDataReader ExecuteDataReader(string sql, IEnumerable parameters);

    }
}
