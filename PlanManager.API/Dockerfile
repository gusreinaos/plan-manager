﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PlanManager.API/PlanManager.API.csproj", "PlanManager.API/"]
RUN dotnet restore "PlanManager.API/PlanManager.API.csproj"
COPY . .
WORKDIR "/src/PlanManager.API"
RUN dotnet build "PlanManager.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlanManager.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlanManager.API.dll"]
