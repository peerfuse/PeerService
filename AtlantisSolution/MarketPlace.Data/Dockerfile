FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MarketPlace.Data/MarketPlace.Data.csproj", "MarketPlace.Data/"]
RUN dotnet restore "MarketPlace.Data/MarketPlace.Data.csproj"
COPY . .
WORKDIR "/src/MarketPlace.Data"
RUN dotnet build "MarketPlace.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MarketPlace.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketPlace.Data.dll"]
