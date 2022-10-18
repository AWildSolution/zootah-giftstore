FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AWildSolutions.Zootah.GiftStore.API/AWildSolutions.Zootah.GiftStore.API.csproj", "AWildSolutions.Zootah.GiftStore.API/"]
RUN dotnet restore "AWildSolutions.Zootah.GiftStore.API/AWildSolutions.Zootah.GiftStore.API.csproj"
COPY . .
WORKDIR "/src/AWildSolutions.Zootah.GiftStore.API"
RUN dotnet build "AWildSolutions.Zootah.GiftStore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AWildSolutions.Zootah.GiftStore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AWildSolutions.Zootah.GiftStore.API.dll"]
