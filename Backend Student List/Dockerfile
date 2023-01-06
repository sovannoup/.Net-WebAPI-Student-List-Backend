#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Backend Student List/Backend Student List.csproj", "Backend Student List/"]
RUN dotnet restore "Backend Student List/Backend Student List.csproj"
COPY . .
WORKDIR "/src/Backend Student List"
RUN dotnet build "Backend Student List.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Backend Student List.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Backend Student List.dll"]