FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Items/Atlantis.Items.csproj", "Atlantis.Items/"]
RUN dotnet restore "Atlantis.Items/Atlantis.Items.csproj"
COPY . .
WORKDIR "/src/Atlantis.Items"
RUN dotnet build "Atlantis.Items.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Items.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Items.dll"]
