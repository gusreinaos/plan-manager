FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PlanManager.Infrastructure/PlanManager.Infrastructure.csproj", "PlanManager.Infrastructure/"]
RUN dotnet restore "PlanManager.Infrastructure/PlanManager.Infrastructure.csproj"
COPY . .
WORKDIR "/src/PlanManager.Infrastructure"
RUN dotnet build "PlanManager.Infrastructure.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlanManager.Infrastructure.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlanManager.Infrastructure.dll"]
