using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql
{
    public class Sql
    {
        public string? SqlString { get; set; }
        public Table? Table { get; set; }

        public Sql()
        {
            this.SqlString = string.Empty;
            this.Table = new Table();
        }

        public void SetTable(object o)
        {
            if (this.Table == null)
                this.Table = new Table();
            this.Table.Name = o.GetType().Name;
            this.Table.Items = this.GetItems(o);
        }

        private Item[] GetItems(object o)
        {
            List<Item> list = new List<Item>();
            System.Reflection.PropertyInfo[] props = o.GetType().GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                Item item = new Item()
                {
                    Name = props[i].Name,
                    Value = props[i].GetValue(o)?.ToString(),
                    Type = props[i].GetValue(o)?.GetType().ToString()
                };
                list.Add(item);
            }
            return list.ToArray();
        }

        public override string ToString()
        {
            return this.SqlString ?? string.Empty;
        }
    }
}
