FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Medium_NuGetPackage_Test_01/Medium_NuGetPackage_Test_01.csproj", "Medium_NuGetPackage_Test_01/"]
RUN dotnet restore "Medium_NuGetPackage_Test_01/Medium_NuGetPackage_Test_01.csproj"
COPY . .
WORKDIR "/src/Medium_NuGetPackage_Test_01"
RUN dotnet build "Medium_NuGetPackage_Test_01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Medium_NuGetPackage_Test_01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Medium_NuGetPackage_Test_01.dll"]
