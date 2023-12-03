using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Select {
    public class Create<T>: 
        SqlBuilder where T: 
        Create<T> {
        public T CreateByObject(object o) {
            this.sql.SetTable(o);
            this.sql.SqlString = $"select { string.Join(", ", this.sql.Table.GetProperties()) } from { this.sql.Table.Name.ToLower() };";
            return (T)this;
        }
    }// class
}// namespace