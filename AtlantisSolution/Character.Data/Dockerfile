FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Character.Data/Character.Data.csproj", "Character.Data/"]
RUN dotnet restore "Character.Data/Character.Data.csproj"
COPY . .
WORKDIR "/src/Character.Data"
RUN dotnet build "Character.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Character.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Character.Data.dll"]
