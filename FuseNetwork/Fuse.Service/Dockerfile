FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Fuse.Service/Fuse.Service.csproj", "Fuse.Service/"]
RUN dotnet restore "Fuse.Service/Fuse.Service.csproj"
COPY . .
WORKDIR "/src/Fuse.Service"
RUN dotnet build "Fuse.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fuse.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fuse.Service.dll"]
