FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Masivian.Casino.API/Masivian.Casino.API.csproj", "Masivian.Casino.API/"]
COPY ["Masivian.Casino.Business/Masivian.Casino.Business.csproj", "Masivian.Casino.Business/"]
COPY ["Masivian.Casino.Entity/Masivian.Casino.Entity.csproj", "Masivian.Casino.Entity/"]
COPY ["Masivian.Casino.Data/Masivian.Casino.Data.csproj", "Masivian.Casino.Data/"]
RUN dotnet restore "Masivian.Casino.API/Masivian.Casino.API.csproj"
COPY . .
WORKDIR "/src/Masivian.Casino.API"
RUN dotnet build "Masivian.Casino.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Masivian.Casino.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Masivian.Casino.API.dll"]
