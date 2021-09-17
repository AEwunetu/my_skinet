# my_skinet
## Commands to remeber
dotnet ef database drop -p Infrastructure -s API
dotnet ef migrations add InitialCreate -p Infrastructure -s API -o Data\Migrations
dotnet ef migrations remove -p Infrastructure -s API
dotnet run -p API
dotnet watch run -p API