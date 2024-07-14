FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Items.Data/Items.Data.csproj", "Items.Data/"]
RUN dotnet restore "Items.Data/Items.Data.csproj"
COPY . .
WORKDIR "/src/Items.Data"
RUN dotnet build "Items.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Items.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Items.Data.dll"]
