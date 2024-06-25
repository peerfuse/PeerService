FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.App/Atlantis.App.csproj", "Atlantis.App/"]
RUN dotnet restore "Atlantis.App/Atlantis.App.csproj"
COPY . .
WORKDIR "/src/Atlantis.App"
RUN dotnet build "Atlantis.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.App.dll"]
