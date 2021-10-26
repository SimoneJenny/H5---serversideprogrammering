#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AspNetCoreMVCTest1/AspNetCoreMVCTest1.csproj", "AspNetCoreMVCTest1/"]
RUN dotnet restore "AspNetCoreMVCTest1/AspNetCoreMVCTest1.csproj"
COPY . .
WORKDIR "/src/AspNetCoreMVCTest1"
RUN dotnet build "AspNetCoreMVCTest1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetCoreMVCTest1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetCoreMVCTest1.dll"]