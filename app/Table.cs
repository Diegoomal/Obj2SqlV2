using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql
{
    public class Table : ICloneable
    {
        public string? Name { get; set; }
        public Item[]? Items { get; set; }

        public Table()
        {
            this.Name = string.Empty;
            this.Items = Array.Empty<Item>();
        }

        public string[] GetProperties()
        {
            if (this.Items == null) {
                throw new ArgumentNullException(nameof(this.Items));
            }

            List<string> lst = new List<string>();
            
            foreach (var item in this.Items)
                lst.Add(item.Name.ToLower());
            
            return lst.ToArray();
        }

        public string[] GetValues()
        {
            if (this.Items == null) {
                throw new ArgumentNullException(nameof(this.Items));
            }
            
            List<string> lst = new List<string>();
            
            foreach (var item in this.Items)
            {
                if (
                    item.Type == typeof(int).ToString() || 
                    item.Type == typeof(double).ToString()
                    ) 
                {
                    lst.Add(item.Value?? string.Empty);
                }
                
                if (
                    item.Type == typeof(string).ToString() || 
                    item.Type == typeof(DateTime).ToString()
                    ) 
                {
                    lst.Add($"'{item.Value}'");
                }
            }
            return lst.ToArray();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name: { this.Name ?? string.Empty }";
        }
    }
}
