FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Login/Atlantis.Login.csproj", "Atlantis.Login/"]
RUN dotnet restore "Atlantis.Login/Atlantis.Login.csproj"
COPY . .
WORKDIR "/src/Atlantis.Login"
RUN dotnet build "Atlantis.Login.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Login.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Login.dll"]
