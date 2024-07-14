FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Character/Atlantis.Character.csproj", "Atlantis.Character/"]
RUN dotnet restore "Atlantis.Character/Atlantis.Character.csproj"
COPY . .
WORKDIR "/src/Atlantis.Character"
RUN dotnet build "Atlantis.Character.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Character.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Character.dll"]
