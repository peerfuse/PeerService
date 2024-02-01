FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PeerFuseAPI/PeerFuseAPI.csproj", "PeerFuseAPI/"]
RUN dotnet restore "PeerFuseAPI/PeerFuseAPI.csproj"
COPY . .
WORKDIR "/src/PeerFuseAPI"
RUN dotnet build "PeerFuseAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PeerFuseAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PeerFuseAPI.dll"]
