FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.GameInfo/Atlantis.GameInfo.csproj", "Atlantis.GameInfo/"]
RUN dotnet restore "Atlantis.GameInfo/Atlantis.GameInfo.csproj"
COPY . .
WORKDIR "/src/Atlantis.GameInfo"
RUN dotnet build "Atlantis.GameInfo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.GameInfo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.GameInfo.dll"]
