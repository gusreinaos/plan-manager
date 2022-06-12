FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PlanManager.Application/PlanManager.Application.csproj", "PlanManager.Application/"]
RUN dotnet restore "PlanManager.Application/PlanManager.Application.csproj"
COPY . .
WORKDIR "/src/PlanManager.Application"
RUN dotnet build "PlanManager.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlanManager.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlanManager.Application.dll"]
