FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:5000;http://+:80
ENV ASPNETCORE_ENVIROMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Data/Atlantis.Data.csproj", "Atlantis.Data/"]
RUN dotnet restore "Atlantis.Data/Atlantis.Data.csproj"
COPY . .
WORKDIR "/src/Atlantis.Data"
RUN dotnet build "Atlantis.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Data.dll"]
