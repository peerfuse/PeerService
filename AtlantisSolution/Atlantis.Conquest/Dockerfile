FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Conquest/Atlantis.Conquest.csproj", "Atlantis.Conquest/"]
RUN dotnet restore "Atlantis.Conquest/Atlantis.Conquest.csproj"
COPY . .
WORKDIR "/src/Atlantis.Conquest"
RUN dotnet build "Atlantis.Conquest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Conquest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Conquest.dll"]
