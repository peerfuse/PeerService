FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Network/Atlantis.Network.csproj", "Atlantis.Network/"]
RUN dotnet restore "Atlantis.Network/Atlantis.Network.csproj"
COPY . .
WORKDIR "/src/Atlantis.Network"
RUN dotnet build "Atlantis.Network.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Network.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Network.dll"]
