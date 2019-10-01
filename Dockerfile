FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY MvcLab01/MvcLab01.csproj MvcLab01/
RUN dotnet restore "MvcLab01/MvcLab01.csproj"
COPY . .
WORKDIR "/src/MvcLab01"
RUN dotnet build "MvcLab01.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MvcLab01.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MvcLab01.dll"]
