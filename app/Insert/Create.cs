using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Insert 
{
    public class Create<T> : SqlBuilder where T : Create<T>
    {
        public T CreateByObject(object o)
        {
            if(o == null) {
                throw new Exception();
            }

            sql.SetTable(o);

            sql.SqlString = string.Format(
                "insert into {0} ({1}) values ({2});", 
                sql.Table.Name.ToLower(),
                string.Join( ", ", sql.Table.GetProperties() ), 
                string.Join( ", ", sql.Table.GetValues() )
            );

            return (T)this;
        }
    }// class
}// namespace