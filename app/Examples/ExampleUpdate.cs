namespace Obj2Sql
{
    public class ExampleUpdate
    {
        public static void Run(string[] fields, Person p)
        {
            string sqlString = string.Empty;

            sqlString = string.Empty;
            sqlString = Convert.ToString( 
                Obj2Sql.Update.Instance.Sql.CreateByObject(p).Build()
            );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString(
                Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields(fields).Build()
            );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString(
                Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields().WhereCondition("id").Build()
            );
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString(
                Obj2Sql.Update.Instance.Sql.CreateByObject(p).Fields(fields).WhereCondition("id").Build()
            );
            System.Console.WriteLine(sqlString);
        }
    }// class
}// namespace