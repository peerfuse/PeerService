FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Igration/Atlantis.Igration.csproj", "Atlantis.Igration/"]
RUN dotnet restore "Atlantis.Igration/Atlantis.Igration.csproj"
COPY . .
WORKDIR "/src/Atlantis.Igration"
RUN dotnet build "Atlantis.Igration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Igration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Igration.dll"]
