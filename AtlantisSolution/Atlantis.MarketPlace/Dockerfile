FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.MarketPlace/Atlantis.MarketPlace.csproj", "Atlantis.MarketPlace/"]
RUN dotnet restore "Atlantis.MarketPlace/Atlantis.MarketPlace.csproj"
COPY . .
WORKDIR "/src/Atlantis.MarketPlace"
RUN dotnet build "Atlantis.MarketPlace.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.MarketPlace.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.MarketPlace.dll"]
