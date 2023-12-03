namespace Obj2Sql
{
    public class ExampleDelete
    {
        public static void Run(string[] campos, Person p)
        {
            System.Console.WriteLine("ExampleDelete_Run");

            if (campos == null) {
                throw new ArgumentNullException(nameof(campos));
            }

            if (p == null) {
                throw new ArgumentNullException(nameof(p));
            }

            string sqlString = string.Empty;
            sqlString = Convert.ToString(Obj2Sql.Delete.Instance.Sql.CreateByObject(p).Build());
            System.Console.WriteLine(sqlString);

            sqlString = string.Empty;
            sqlString = Convert.ToString(Obj2Sql.Delete.Instance.Sql.CreateByObject(p).WhereCondition("id").Build());
            System.Console.WriteLine(sqlString);
        }
    }
}