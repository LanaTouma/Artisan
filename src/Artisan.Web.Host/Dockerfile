FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Artisan.Web.Host/Artisan.Web.Host.csproj", "src/Artisan.Web.Host/"]
COPY ["src/Artisan.Web.Core/Artisan.Web.Core.csproj", "src/Artisan.Web.Core/"]
COPY ["src/Artisan.Application/Artisan.Application.csproj", "src/Artisan.Application/"]
COPY ["src/Artisan.Core/Artisan.Core.csproj", "src/Artisan.Core/"]
COPY ["src/Artisan.EntityFrameworkCore/Artisan.EntityFrameworkCore.csproj", "src/Artisan.EntityFrameworkCore/"]
WORKDIR "/src/src/Artisan.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Artisan.Web.Host", "src/Artisan.Web.Host"]
COPY ["src/Artisan.Web.Core", "src/Artisan.Web.Core"]
COPY ["src/Artisan.Application", "src/Artisan.Application"]
COPY ["src/Artisan.Core", "src/Artisan.Core"]
COPY ["src/Artisan.EntityFrameworkCore", "src/Artisan.EntityFrameworkCore"]
WORKDIR "/src/src/Artisan.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Artisan.Web.Host.dll"]
