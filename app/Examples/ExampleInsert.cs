namespace Obj2Sql
{
    public class ExampleInsert
    {
        public static void Run(string[] fields, Person p)
        {
            System.Console.WriteLine("INSERT");

            string sqlString = string.Empty;

            sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Build() );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields(fields).Build()  );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields().Returning("id").Build()  );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Fields(fields).Returning("id").Build()  );
            System.Console.WriteLine(sqlString);
        }
    }// class
}// namespace