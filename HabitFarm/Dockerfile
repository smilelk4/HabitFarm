FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HabitFarm/HabitFarm.csproj", "HabitFarm/"]
RUN dotnet restore "HabitFarm/HabitFarm.csproj"
COPY . .
WORKDIR "/src/HabitFarm"
RUN dotnet build "HabitFarm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HabitFarm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HabitFarm.dll"]
