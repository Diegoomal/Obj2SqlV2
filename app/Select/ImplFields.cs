using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Select {    
    public class ImplFields<T>: 
        Create<ImplFields<T>> where T: 
        ImplFields<T> {

        public T Fields(){
            return (T)this;
        }

        public T Fields(string[] fields) {
            sql.SqlString = string.Empty;
            string[] fieldsTable = this.sql.Table.GetProperties();
            string[] diff_fields = fields.Intersect(fieldsTable).ToArray();
            sql.SqlString = $"select { string.Join(", ", diff_fields) } from { this.sql.Table.Name.ToLower() };";
            return (T)this;
        }

    }// class
}// namespace