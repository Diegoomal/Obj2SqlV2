using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Select {    
    public class ImplWhere<T>: 
        ImplFields<ImplWhere<T>> where T: 
        ImplWhere<T> {

        public T Where(string field) {

            // field = field.ToLower();
            // Item[] items = this.sql.Table.Items;
            // foreach (var item in items) {
            // }

            return (T)this;
        }

    }// class
}// namespace