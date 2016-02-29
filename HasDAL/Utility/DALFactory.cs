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

        private static Dictionary<byte, Type> _dalList = new Dictionary<byte, Type>() { 
            {(byte)DalTypes.Oracle,typeof(OracleDAL)},
            {(byte)DalTypes.MsSql,typeof(MsSqlDAL)},
            {(byte)DalTypes.MySql,typeof(MySqlDAL)},
            {(byte)DalTypes.NoSql,typeof(NoSqlDAL)}
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
                        var dalType = _dalList[keyDal];
                        instance = (IDal)Activator.CreateInstance(dalType);
                    }
                }
             }

             return instance;
          }
       }
    }
}
