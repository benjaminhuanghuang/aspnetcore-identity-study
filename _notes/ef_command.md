## Reference
    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
    
    EF tool can find db name and db connection in source code
    
## Manage database

    $ dotnet ef database drop
    $ dotnet ef database update   # update the database the latest version (apply all migrations)
    $ dotnet ef database update <migration name>  

## Manage migrations
    $ dotnet ef migrations list
    $ dotnet ef migrations add <migration name>   # add a new migration
    $ dotnet ef migrations remove  # remove the most recent migration.
    $ dotnet ef migrations script  # Generates a SQL script from migrations.

## Manage DbContext

    $ dotnet ef dbcontext info
    $ dotnet ef dbcontext list
    $ dotnet ef dbcontext scaffold <CONNECTION>