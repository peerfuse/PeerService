FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Inventory/Atlantis.Inventory.csproj", "Atlantis.Inventory/"]
RUN dotnet restore "Atlantis.Inventory/Atlantis.Inventory.csproj"
COPY . .
WORKDIR "/src/Atlantis.Inventory"
RUN dotnet build "Atlantis.Inventory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Inventory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Inventory.dll"]
