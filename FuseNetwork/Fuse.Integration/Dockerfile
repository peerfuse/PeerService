FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Fuse.Integration/Fuse.Integration.csproj", "Fuse.Integration/"]
RUN dotnet restore "Fuse.Integration/Fuse.Integration.csproj"
COPY . .
WORKDIR "/src/Fuse.Integration"
RUN dotnet build "Fuse.Integration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fuse.Integration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fuse.Integration.dll"]
