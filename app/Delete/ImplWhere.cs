using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Delete 
{
    public class ImplWhere<T> : Create<ImplWhere<T>> where T : ImplWhere<T>
    {
        public T Where(string tableField)
        {
            foreach (var item in this.sql.Table.Items) {
                if(!item.Name.ToLower().Equals(tableField.ToLower())) continue;
                if (typeof(int).ToString().Equals(item.Type) || typeof(double).ToString().Equals(item.Type)) 
                    sql.SqlString = sql.SqlString.Replace(";", $" where { tableField } = { item.Value };");
                if (typeof(string).ToString().Equals(item.Type) || typeof(DateTime).ToString().Equals(item.Type)) 
                    sql.SqlString = sql.SqlString.Replace(";", $" where { tableField } = '{ item.Value }';");
            }
            return (T)this;
        }
    }// class
}// namespace
