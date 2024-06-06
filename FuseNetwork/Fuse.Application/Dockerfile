FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Fuse.Application/Fuse.Application.csproj", "Fuse.Application/"]
RUN dotnet restore "Fuse.Application/Fuse.Application.csproj"
COPY . .
WORKDIR "/src/Fuse.Application"
RUN dotnet build "Fuse.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fuse.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fuse.Application.dll"]
