using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Delete {    
    
    public class ImplWhere<T> : Create<ImplWhere<T>> where T : ImplWhere<T>
    {
        public T WhereCondition(string tableField)
        {
            if (tableField == null) {
                throw new ArgumentNullException(nameof(tableField));
            }

            if (this.sql.Table.Items == null) {
                throw new ArgumentNullException(nameof(this.sql.Table.Items));
            }

            foreach (var item in this.sql.Table.Items) {
                if(tableField.ToLower().Equals(item.Name.ToLower())) {

                    if ( 
                        typeof(int).ToString().Equals(item.Type) || 
                        typeof(double).ToString().Equals(item.Type)
                    ) {
                        sql.SqlString = sql.SqlString.Replace(
                            ";", $" where { tableField } = { item.Value };"
                        );
                    }
                    
                    if (
                        typeof(string).ToString().Equals(item.Type) || 
                        typeof(DateTime).ToString().Equals(item.Type)
                     ) {
                        sql.SqlString = sql.SqlString.Replace(
                            ";", $" where { tableField } = '{ item.Value }';"
                        );
                    }

                }
            }

            return (T)this;
        }

    }

}
