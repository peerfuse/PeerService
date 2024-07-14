FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Progress.Data/Progress.Data.csproj", "Progress.Data/"]
RUN dotnet restore "Progress.Data/Progress.Data.csproj"
COPY . .
WORKDIR "/src/Progress.Data"
RUN dotnet build "Progress.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Progress.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Progress.Data.dll"]
