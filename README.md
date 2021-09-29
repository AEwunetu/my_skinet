# my_skinet
## Commands to remeber
dotnet tool install --global dotnet-ef --version 5.0.401
dotnet tool update --global dotnet-ef --version 5.0.401
dotnet tool uninstall --global dotnet-ef
dotnet ef database update 
dotnet ef database drop -p Infrastructure -s API
dotnet ef migrations add InitialCreate -p Infrastructure -s API -o Data\Migrations
dotnet ef migrations remove -p Infrastructure -s API
dotnet run -p API
dotnet watch run -p API