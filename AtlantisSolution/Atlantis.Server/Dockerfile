FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Server/Atlantis.Server.csproj", "Atlantis.Server/"]
RUN dotnet restore "Atlantis.Server/Atlantis.Server.csproj"
COPY . .
WORKDIR "/src/Atlantis.Server"
RUN dotnet build "Atlantis.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Server.dll"]
