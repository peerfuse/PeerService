FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Fuse.Data/Fuse.Data.csproj", "Fuse.Data/"]
RUN dotnet restore "Fuse.Data/Fuse.Data.csproj"
COPY . .
WORKDIR "/src/Fuse.Data"
RUN dotnet build "Fuse.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fuse.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fuse.Data.dll"]
