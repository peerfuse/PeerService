FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Integration/Atlantis.Integration.csproj", "Atlantis.Integration/"]
RUN dotnet restore "Atlantis.Integration/Atlantis.Integration.csproj"
COPY . .
WORKDIR "/src/Atlantis.Integration"
RUN dotnet build "Atlantis.Integration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Integration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Integration.dll"]
