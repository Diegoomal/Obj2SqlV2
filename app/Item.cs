using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql
{
    public class Item : ICloneable
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }

        public Item()
        {
            this.Name = string.Empty;
            this.Value = string.Empty;
            this.Type = string.Empty;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Type: { this.Type ?? string.Empty } - Property: { this.Name ?? string.Empty } - Value: { this.Value ?? string.Empty }";
        }
    }
}
