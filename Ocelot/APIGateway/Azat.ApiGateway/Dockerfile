#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app/azatapi
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./Azat.ApiGateway/Azat.ApiGateway.csproj", "src/Azat.ApiGateway.csproj"]
RUN dotnet restore "src/Azat.ApiGateway.csproj"
COPY . .
RUN dotnet build "./Azat.ApiGateway/Azat.ApiGateway.csproj" -c Release -o /app/azatapi/build

FROM build AS publish
RUN dotnet publish "./Azat.ApiGateway/Azat.ApiGateway.csproj" -c Release -o /app/azatapi/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app/azatapp
COPY --from=publish /app/azatapi/publish .
ENTRYPOINT ["dotnet", "Azat.ApiGateway.dll"]