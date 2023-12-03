namespace Obj2Sql {
    public class Person : IEntity {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }

        public override string ToString()
        {
            return $"{ this.Id } - { this.Name ?? string.Empty } { this.Lastname ?? string.Empty }";
        }
    }
}