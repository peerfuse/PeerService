FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["P2PokerAPI/P2PokerAPI.csproj", "P2PokerAPI/"]
RUN dotnet restore "P2PokerAPI/P2PokerAPI.csproj"
COPY . .
WORKDIR "/src/P2PokerAPI"
RUN dotnet build "P2PokerAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "P2PokerAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "P2PokerAPI.dll"]
