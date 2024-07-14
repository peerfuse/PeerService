FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Conquest.Data/Conquest.Data.csproj", "Conquest.Data/"]
RUN dotnet restore "Conquest.Data/Conquest.Data.csproj"
COPY . .
WORKDIR "/src/Conquest.Data"
RUN dotnet build "Conquest.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Conquest.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Conquest.Data.dll"]
