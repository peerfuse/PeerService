FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Inventory.Data/Inventory.Data.csproj", "Inventory.Data/"]
RUN dotnet restore "Inventory.Data/Inventory.Data.csproj"
COPY . .
WORKDIR "/src/Inventory.Data"
RUN dotnet build "Inventory.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inventory.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Inventory.Data.dll"]
