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

        public string[] GetProperties()
        {
            List<string> lst = new List<string>();
            
            foreach (var item in this.Items)
                lst.Add(item.Name.ToLower());
            
            return lst.ToArray();
        }

        public string[] GetValues()
        {            
            List<string> lst = new List<string>();
            
            foreach (var item in this.Items) {
                if (
                    typeof(int).ToString().Equals(item.Type) || 
                    typeof(double).ToString().Equals(item.Type)
                ) 
                    lst.Add(item.Value);
                
                if (
                    typeof(string).ToString().Equals(item.Type) || 
                    typeof(DateTime).ToString().Equals(item.Type)
                )
                    lst.Add($"'{item.Value}'");
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
