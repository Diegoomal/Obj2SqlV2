namespace Obj2Sql
{
    public class ExampleSelect
    {
        public static void Run(string[] fields, Person p)
        {
            string sqlString = string.Empty;

            sqlString = string.Empty;
            sqlString = Convert.ToString( 
                Obj2Sql.Select.Instance.Sql.CreateByObject(p).Build()
            );
            System.Console.WriteLine(sqlString);

            // sqlString = string.Empty;
            // sqlString = Convert.ToString( 
            //     Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields(campos).Build()
            // );
            // System.Console.WriteLine(sqlString);


            // sqlString = string.Empty;
            // sqlString = Convert.ToString( 
            //     Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields().Where("id").Build()
            // );
            // System.Console.WriteLine(sqlString);

            // sqlString = string.Empty;
            // sqlString = Convert.ToString( 
            //     Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields().Where("nome").Build()
            // );
            // System.Console.WriteLine(sqlString);

            // sqlString = string.Empty;
            // sqlString = Convert.ToString( 
            //     Obj2Sql.Select.Instance.Sql.CreateByObject(p).Fields(campos).Where("id").Build()
            // );
            // System.Console.WriteLine(sqlString);
        }
    }// class
}// namespace