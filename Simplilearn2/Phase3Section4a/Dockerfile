#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Phase3Section4a/Phase3Section4a.csproj", "Phase3Section4a/"]
COPY ["SchoolEfDAL/SchoolEfDAL.csproj", "SchoolEfDAL/"]
RUN dotnet restore "Phase3Section4a/Phase3Section4a.csproj"
COPY . .
WORKDIR "/src/Phase3Section4a"
RUN dotnet build "Phase3Section4a.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Phase3Section4a.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Phase3Section4a.dll"]
