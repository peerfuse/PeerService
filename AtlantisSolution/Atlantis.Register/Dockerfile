FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:8080;http://+:80
ENV ASPNETCORE_ENVIROMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Register/Atlantis.Register.csproj", "Atlantis.Register/"]
RUN dotnet restore "Atlantis.Register/Atlantis.Register.csproj"
COPY . .
WORKDIR "/src/Atlantis.Register"
RUN dotnet build "Atlantis.Register.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Register.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Register.dll"]
