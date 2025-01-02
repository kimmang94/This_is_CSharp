using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_96
{
    internal class OracleManager : IDatabaseManager
    {
        public void Open(DatabaseInfo daInfo)
        {
            //ToDo
        }

        public DataTable Select (string sql)
        {
            //ToDo
            return new DataTable();
        }

        public int Insert(string sql)
        {
            // ToDo
            return 0;
        }

        public int Update(string sql)
        {
            return 0;
        }

        public int Delete(string sql)
        {
            return 0;
        }

        public void Close()
        {
            // ToDo
        }
    }
}
