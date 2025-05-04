# Build script docker build -t nihfix/valetudo.mcp -f ./NihFix.Valetudo.Mcp/Dockerfile .
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
#USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NihFix.Valetudo.Mcp/NihFix.Valetudo.Mcp.csproj", "NihFix.Valetudo.Mcp/"]
COPY ["NihFix.Valetudo.HttpClient/NihFix.Valetudo.HttpClient.csproj", "NihFix.Valetudo.HttpClient/"]
RUN dotnet restore "NihFix.Valetudo.Mcp/NihFix.Valetudo.Mcp.csproj"
COPY . .
WORKDIR "/src/NihFix.Valetudo.Mcp"
RUN dotnet build "./NihFix.Valetudo.Mcp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NihFix.Valetudo.Mcp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NihFix.Valetudo.Mcp.dll"]
