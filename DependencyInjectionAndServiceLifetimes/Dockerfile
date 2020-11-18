#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["DependencyInjectionAndServiceLifetimes/DependencyInjectionAndServiceLifetimes.csproj", "DependencyInjectionAndServiceLifetimes/"]
RUN dotnet restore "DependencyInjectionAndServiceLifetimes/DependencyInjectionAndServiceLifetimes.csproj"
COPY . .
WORKDIR "/src/DependencyInjectionAndServiceLifetimes"
RUN dotnet build "DependencyInjectionAndServiceLifetimes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DependencyInjectionAndServiceLifetimes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DependencyInjectionAndServiceLifetimes.dll"]