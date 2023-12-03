namespace Obj2Sql
{
    public class ExampleDelete
    {
        public static void Run(string[] campos, Person p)
        {
            string sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Delete.Instance.Sql.CreateByObject(p).Build() );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString( Obj2Sql.Delete.Instance.Sql.CreateByObject(p).WhereCondition("id").Build() );
            System.Console.WriteLine(sqlString);
        }
    }// class
}// namespace