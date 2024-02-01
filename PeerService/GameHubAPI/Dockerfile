FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GameHubAPI/GameHubAPI.csproj", "GameHubAPI/"]
RUN dotnet restore "GameHubAPI/GameHubAPI.csproj"
COPY . .
WORKDIR "/src/GameHubAPI"
RUN dotnet build "GameHubAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameHubAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameHubAPI.dll"]
