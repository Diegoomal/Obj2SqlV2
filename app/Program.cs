using System;

namespace Obj2Sql
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Id = 1, Name = "Diego", Lastname = "Maldonado" };

            string[] fields = new string[] { "id", "name" };

            ExampleInsert.Run(fields, person);
            // ExampleSelect.Run(fields, person);
            // ExampleUpdate.Run(fields, person);
            // ExampleDelete.Run(fields, person);


        }
    }
}