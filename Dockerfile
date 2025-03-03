FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY WeaponShop.csproj ./
RUN dotnet restore "WeaponShop.csproj"

COPY . .  
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /publish .

EXPOSE 80
CMD ["dotnet", "WeaponShop.dll"]