FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Perfil.Data/Perfil.Data.csproj", "Perfil.Data/"]
RUN dotnet restore "Perfil.Data/Perfil.Data.csproj"
COPY . .
WORKDIR "/src/Perfil.Data"
RUN dotnet build "Perfil.Data.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Perfil.Data.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Perfil.Data.dll"]
