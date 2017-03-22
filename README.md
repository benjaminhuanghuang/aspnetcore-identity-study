ASP.NET Core Identity Study Project
======================================

Points
-------------------------------------
ASP.NET Core  




How to run
-------------------------------------
* Start the mssql docker 
    
    $ docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Sql@1433' -p 1433:1433 -d microsoft/mssql-server-linux

* Recover databas 
    
    $dotnet ef database update

* Start app 
    
    $ dotnet run

* Login 
    test@gmail.com/ Test1234