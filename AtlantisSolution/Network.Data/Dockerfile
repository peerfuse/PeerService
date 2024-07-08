FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Network.Data/Network.Data.csproj", "Network.Data/"]
RUN dotnet restore "Network.Data/Network.Data.csproj"
COPY . .
WORKDIR "/src/Network.Data"
RUN dotnet build "Network.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Network.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Network.Data.dll"]
