using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Insert {    
    
    public class ImplFields<T> : Create<ImplFields<T>> where T: ImplFields<T>
    {
        public T Fields() {
            return (T)this;
        }

        public T Fields(string[] fields) {

            sql.SqlString = string.Empty;
            List<string> _fields_ = new List<string>();
            List<string> _values_ = new List<string>();
            Item[] items = this.sql.Table.Items.Where(
                o => fields.Contains( o.Name.ToLower() )
            ).ToArray();
            
            foreach (var item in items) {
                _fields_.Add(item.Name.ToLower());
                if ( typeof(int).ToString().Equals(item.Type) || typeof(double).ToString().Equals(item.Type)) 
                    _values_.Add(item.Value.ToString());
                if (typeof(string).ToString().Equals(item.Type) || typeof(DateTime).ToString().Equals(item.Type)) 
                    _values_.Add($"'{ item.Value.ToString() }'");
            }

            sql.SqlString = string.Format(
                "insert into {0} ({1}) values ({2});",
                this.sql.Table.Name,
                string.Join(", ", _fields_),
                string.Join(", ", _values_)
            );

            return (T)this;
        }

    }// class
}// namespace
