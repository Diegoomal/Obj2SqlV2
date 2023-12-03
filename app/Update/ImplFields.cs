using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Update  {    
    
    public class ImplFields<T> : Create<ImplFields<T>> where T: ImplFields<T>
    {
        public T Fields() {
            return (T)this;
        }

        public T Fields(string[] fields) {

            sql.SqlString = string.Empty;

            // sql.SqlString = string.Empty;
            // string[] fieldsTable = this.sql.Table.GetProperties();
            // string[] diff_fields = fields.Intersect(fieldsTable).ToArray();
            // sql.SqlString = $"update { this.sql.Table.Name } set { string.Join(", ", diff_fields) } ;";

            return (T)this;
        }

    }// class
}// namespace
