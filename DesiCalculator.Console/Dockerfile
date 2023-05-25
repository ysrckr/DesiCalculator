FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DesiCalculator.Console/DesiCalculator.Console.csproj", "DesiCalculator.Console/"]
RUN dotnet restore "DesiCalculator.Console/DesiCalculator.Console.csproj"
COPY . .
WORKDIR "/src/DesiCalculator.Console"
RUN dotnet build "DesiCalculator.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesiCalculator.Console.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesiCalculator.Console.dll"]
