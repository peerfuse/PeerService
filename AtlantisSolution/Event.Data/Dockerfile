FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Event.Data/Event.Data.csproj", "Event.Data/"]
RUN dotnet restore "Event.Data/Event.Data.csproj"
COPY . .
WORKDIR "/src/Event.Data"
RUN dotnet build "Event.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Event.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Event.Data.dll"]
