#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG NUGET_URL
ARG NUGET_USERNAME
ARG NUGET_PASSWORD
WORKDIR /src
COPY ["src/Bz.F8t.Registration.WebAPI/Bz.F8t.Registration.WebAPI.csproj", "src/Bz.F8t.Registration.WebAPI/"]
COPY ["src/Bz.F8t.Registration.Application/Bz.F8t.Registration.Application.csproj", "src/Bz.F8t.Registration.Application/"]
COPY ["src/Bz.F8t.Registration.Domain/Bz.F8t.Registration.Domain.csproj", "src/Bz.F8t.Registration.Domain/"]
COPY ["src/Bz.F8t.Registration.Infrastructure/Bz.F8t.Registration.Infrastructure.csproj", "src/Bz.F8t.Registration.Infrastructure/"]
RUN dotnet nuget add source $NUGET_URL -n beniamin_github -u $NUGET_USERNAME -p $NUGET_PASSWORD --store-password-in-clear-text
RUN dotnet restore "src/Bz.F8t.Registration.WebAPI/Bz.F8t.Registration.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Bz.F8t.Registration.WebAPI"
RUN dotnet build "Bz.F8t.Registration.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bz.F8t.Registration.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bz.F8t.Registration.WebAPI.dll"]