FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Occupation/Atlantis.Occupation.csproj", "Atlantis.Occupation/"]
RUN dotnet restore "Atlantis.Occupation/Atlantis.Occupation.csproj"
COPY . .
WORKDIR "/src/Atlantis.Occupation"
RUN dotnet build "Atlantis.Occupation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Occupation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Occupation.dll"]
