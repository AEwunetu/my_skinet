# my_skinet
## Commands to remeber
1. dotnet tool install --global dotnet-ef --version 5.0.401
2. dotnet tool update --global dotnet-ef --version 5.0.401
3. dotnet tool uninstall --global dotnet-ef
4. dotnet ef database update 
5. dotnet ef database drop -p Infrastructure -s API
6. dotnet ef migrations add InitialCreate -p Infrastructure -s API -o Data\Migrations
7. dotnet ef migrations add IdentityInitital -p Infrastructure -s API -o Identity/Migrations -c AppIdentityDbContext
8. dotnet ef migrations remove -p Infrastructure -s API
9. dotnet run -p API
10. dotnet watch run -p API
