FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:7200;http://+:80
ENV ASPNETCORE_ENVIROMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Atlantis.Chat/Atlantis.Chat.csproj", "Atlantis.Chat/"]
RUN dotnet restore "Atlantis.Chat/Atlantis.Chat.csproj"
COPY . .
WORKDIR "/src/Atlantis.Chat"
RUN dotnet build "Atlantis.Chat.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atlantis.Chat.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atlantis.Chat.dll"]
