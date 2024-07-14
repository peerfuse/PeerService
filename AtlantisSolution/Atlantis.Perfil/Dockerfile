FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Perfil/Atlantis.Perfil.csproj", "Atlantis.Perfil/"]
RUN dotnet restore "Atlantis.Perfil/Atlantis.Perfil.csproj"
COPY . .
WORKDIR "/src/Atlantis.Perfil"
RUN dotnet build "Atlantis.Perfil.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Perfil.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Perfil.dll"]
