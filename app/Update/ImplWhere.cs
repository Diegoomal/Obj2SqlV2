using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Update {    
    
    public class ImplWhere<T> : ImplFields<ImplWhere<T>> where T : ImplWhere<T>
    {
        public T Where(string tableField)
        {

            Item[] items = this.sql.Table.Items.ToArray();
            
            foreach (var item in items) {                
                if(!item.Name.ToLower().Equals(tableField)) continue;
                if ( typeof(int).ToString().Equals(item.Type) || typeof(double).ToString().Equals(item.Type)) 
                    sql.SqlString = sql.SqlString.Replace(";", $" where { tableField } = { item.Value };");
                if (typeof(string).ToString().Equals(item.Type) || typeof(DateTime).ToString().Equals(item.Type)) 
                    sql.SqlString = sql.SqlString.Replace(";", $" where { tableField } = '{ item.Value }';");
            }

            return (T)this;
        }
    }// class
}// namespace
