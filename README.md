# Let's Practice with dotnet

Sample app settings 

# Notes: 

### Basics

bool
char
int/uint
long/uint
double - floating point
decimal - precision for money
string 

### Classes

### Generics

### Type Checking

### Garbage Collection 



### Dependency Injection

'new' = Tight Coupling 

DI Container or IoC Container
Inversion of Control. The container is responsible for maintaining a list of dependencies of the application. 

Loose Coupling: 
interface IClassA
{
    void DoSomething(); 
}


### Good things about migrations: 
Migrations are good because your models always match the database. This can be good for consistency. 
This also provides some version control. We don't have to export our schema. 
We can quickly role-back to previous versions of your data. 

To create our first migration: 
`dotnet ef migrations add InitialMigration` 

