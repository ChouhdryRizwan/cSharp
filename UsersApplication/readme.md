# Install these packages
## Step 1
Install these packages 
1) Microsoft.EntityFrameworkCore.SqlServer
2) Microsoft.EntityFrameworkCore.Tools
3) Microsoft.EntityFrameworkCore.Design

## Step 2
Create Model Class (e.g Student)

```
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName="varchar(120)")]
        public string Name { get; set; }
        [Column("StudentEmail", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column("Mobile", TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }
        [Column("StudentAddress", TypeName = "varchar(250)")]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
```

## Step 3
Create DbContext Class (e.g UserDbContext)

```
using Microsoft.EntityFrameworkCore;

namespace UsersApplication.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}

```
## Step 4
Create Connection String in appsettings.json
 
* if you use SQL Server Authentication 
```  
"ConnectionStrings": {
  "conn": "Server=.;Database=UsersDb;User Id=sa;Password=1234;Encrypt=True;TrustServerCertificate=True;"
}
```
* if you use Windows Authentication 
```  
"ConnectionStrings": {
  "conn": "Server=.;Database=UsersDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
}

```

## Step 5
Add this connection string in Program.cs file.

```
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<UserDBContext>(item => item.UseSqlServer(
    config.GetConnectionString("conn")));
```

## Step 6
Add and Run Migrations

1) add-migration createStudents
2) update-database 


## Step 7
* For Further information please explore folder structure