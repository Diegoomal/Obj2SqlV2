# Obj2Sql - **docker** e **dotnet core**

The project has been implemented with the Fluent Interface design pattern and is designed to create SQL commands using the reflection library.

## Demonstration

```
Person person = new Person() { Id = 1, Name = "Diego", Lastname = "Maldonado" };

string[] fields = new string[] { "id", "name" };

string sqlString = Convert.ToString(Obj2Sql.Insert.Instance.Sql.CreateByObject(p).Build());

System.Console.WriteLine(sqlString);

```

output
```
insert into person (id, name, lastname) values (1, 'Diego', 'Maldonado');
```

## To Execute project

### Create docker image

```
docker image build -t img_app_obj2sql .
```

### Execute docker image

```
docker run img_app_obj2sql
```