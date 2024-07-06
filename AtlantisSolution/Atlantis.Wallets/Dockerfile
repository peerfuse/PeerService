FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:5050;http://+:80
ENV ASPNETCORE_ENVIROMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Wallets/Atlantis.Wallets.csproj", "Atlantis.Wallets/"]
RUN dotnet restore "Atlantis.Wallets/Atlantis.Wallets.csproj"
COPY . .
WORKDIR "/src/Atlantis.Wallets"
RUN dotnet build "Atlantis.Wallets.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Wallets.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Wallets.dll"]
