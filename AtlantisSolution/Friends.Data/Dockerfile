FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Friends.Data/Friends.Data.csproj", "Friends.Data/"]
RUN dotnet restore "Friends.Data/Friends.Data.csproj"
COPY . .
WORKDIR "/src/Friends.Data"
RUN dotnet build "Friends.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Friends.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Friends.Data.dll"]
