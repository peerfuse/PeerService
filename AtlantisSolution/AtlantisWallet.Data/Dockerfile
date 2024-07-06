FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:5100;http://+:80
ENV ASPNETCORE_ENVIROMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["AtlantisWallet.Data/AtlantisWallet.Data.csproj", "AtlantisWallet.Data/"]
RUN dotnet restore "AtlantisWallet.Data/AtlantisWallet.Data.csproj"
COPY . .
WORKDIR "/src/AtlantisWallet.Data"
RUN dotnet build "AtlantisWallet.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AtlantisWallet.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AtlantisWallet.Data.dll"]
