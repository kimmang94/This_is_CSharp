using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_96
{
    public interface IDatabaseManager
    {
        void Open(DatabaseInfo dbInfo);
        DataTable Select(string sql);
        int Insert(string sql);
        int Update(string sql);
        int Delete(string sql);
        void Close();

    }
}
