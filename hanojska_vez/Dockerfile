FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["hanojska_vez/hanojska_vez.csproj", "hanojska_vez/"]
RUN dotnet restore "hanojska_vez/hanojska_vez.csproj"
COPY . .
WORKDIR "/src/hanojska_vez"
RUN dotnet build "hanojska_vez.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hanojska_vez.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hanojska_vez.dll"]
