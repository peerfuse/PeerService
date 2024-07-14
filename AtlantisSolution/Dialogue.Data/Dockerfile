FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Dialogue.Data/Dialogue.Data.csproj", "Dialogue.Data/"]
RUN dotnet restore "Dialogue.Data/Dialogue.Data.csproj"
COPY . .
WORKDIR "/src/Dialogue.Data"
RUN dotnet build "Dialogue.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dialogue.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dialogue.Data.dll"]
