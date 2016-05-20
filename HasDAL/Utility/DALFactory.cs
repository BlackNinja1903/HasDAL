using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HasDAL.Utility
{
    public sealed class DalFactory
    {
		private const byte DEFAULT_DBMS = (byte)DalTypes.Oracle;

        private static Dictionary<byte, Func<IDal>> _dalList = new Dictionary<byte, Func<IDal>>() { 
            {(byte)DalTypes.Oracle,()=>new OracleDAL()},
            {(byte)DalTypes.MsSql,()=> new MsSqlDAL()},
            {(byte)DalTypes.MySql,()=>new MySqlDAL()},
            {(byte)DalTypes.NoSql,()=>new NoSqlDAL()}
        }; 
       private static volatile IDal instance;
       private static object syncRoot = new Object();

       private DalFactory() { }

       public static IDal Instance
       {
          get 
          {
             if (instance == null) 
             {
                lock (syncRoot) 
                {
                    if (instance == null)
                    {
						byte keyDal = DEFAULT_DBMS;
						byte.TryParse(ConfigurationManager.AppSettings["DalType"].ToString(),out keyDal);
                        instance = _dalList[keyDal]();
                    }
                }
             }

             return instance;
          }
       }
    }
}
