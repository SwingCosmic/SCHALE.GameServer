#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SCHALE.GameServer/SCHALE.GameServer.csproj", "SCHALE.GameServer/"]
COPY ["SCHALE.Common/SCHALE.Common.csproj", "SCHALE.Common/"]
RUN dotnet restore "./SCHALE.GameServer/SCHALE.GameServer.csproj"
COPY . .
WORKDIR "/src/SCHALE.GameServer"
RUN dotnet build "./SCHALE.GameServer.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SCHALE.GameServer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8


ENTRYPOINT ["dotnet", "SCHALE.GameServer.dll"]