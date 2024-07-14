FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Friends/Atlantis.Friends.csproj", "Atlantis.Friends/"]
RUN dotnet restore "Atlantis.Friends/Atlantis.Friends.csproj"
COPY . .
WORKDIR "/src/Atlantis.Friends"
RUN dotnet build "Atlantis.Friends.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Friends.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Friends.dll"]
