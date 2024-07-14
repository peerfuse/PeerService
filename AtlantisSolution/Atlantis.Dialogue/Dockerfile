FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Dialogue/Atlantis.Dialogue.csproj", "Atlantis.Dialogue/"]
RUN dotnet restore "Atlantis.Dialogue/Atlantis.Dialogue.csproj"
COPY . .
WORKDIR "/src/Atlantis.Dialogue"
RUN dotnet build "Atlantis.Dialogue.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Dialogue.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Dialogue.dll"]
