FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["flutter_testing_megapack_backend/flutter_testing_megapack_backend.csproj", "flutter_testing_megapack_backend/"]
RUN dotnet restore "flutter_testing_megapack_backend/flutter_testing_megapack_backend.csproj"
COPY . .
WORKDIR "/src/flutter_testing_megapack_backend"
RUN dotnet build "flutter_testing_megapack_backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "flutter_testing_megapack_backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "flutter_testing_megapack_backend.dll"]
