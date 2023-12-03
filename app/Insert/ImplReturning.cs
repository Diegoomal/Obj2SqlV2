using System;
using System.Collections.Generic;
using System.Text;

namespace Obj2Sql.Insert {    
    public class ImplReturning<T>: 
        ImplFields<ImplReturning<T>> where T: 
        ImplReturning<T> {

        public T Returning() {            
            sql.SqlString = sql.SqlString.Replace(";", " returning id;");
            return (T)this;            
        }

        public T Returning(string field) {
            sql.SqlString = sql.SqlString.Replace(
                ";", $" returning { field.ToLower() };"
            );
            return (T)this;
        }
    }// class
}// namespace