using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql.Update 
{
    public class Create<T> : SqlBuilder where T : Create<T>
    {
        public T CreateByObject(object o)
        {
            sql.SetTable(o);

            List<string> fieldsValues = new List<string>();

            Item[] items = this.sql.Table.Items;

            foreach (var item in items) {
                string sAux = string.Empty;
                if ( typeof(int).ToString().Equals(item.Type) || typeof(double).ToString().Equals(item.Type)) 
                    sAux = $"{ item.Name.ToLower() } = { item.Value }";
                if (typeof(string).ToString().Equals(item.Type) || typeof(DateTime).ToString().Equals(item.Type)) 
                    sAux = $"{ item.Name.ToLower() } = '{ item.Value }'";
                fieldsValues.Add(sAux);
            }

            return (T)this;
        }
    }// class
}// namespace