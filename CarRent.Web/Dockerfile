FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CarRent.Web/CarRent.Web.csproj", "CarRent.Web/"]
RUN dotnet restore "CarRent.Web/CarRent.Web.csproj"
COPY . .
WORKDIR "/src/CarRent.Web"
RUN dotnet build "CarRent.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CarRent.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CarRent.Web.dll"]