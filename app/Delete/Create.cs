using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Delete 
{
    public class Create<T> : SqlBuilder where T : Create<T>
    {
        public T CreateByObject(object o)
        {
            sql.SetTable(o);

            sql.SqlString = $"DELETE FROM { sql.Table.Name.ToLower() };";
            
            return (T)this;
        }
    }// class
}// namespace