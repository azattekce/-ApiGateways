#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/ContactAPI/Contact.API/Contact.API.csproj", "Services/ContactAPI/Contact.API/"]
COPY ["Core/Core.WebAPI/Core.WebAPI.csproj", "Core/Core.WebAPI/"]
COPY ["Core/Core.Application/Core.Application.csproj", "Core/Core.Application/"]
COPY ["Core/Core.CrossCuttingConcerns/Core.CrossCuttingConcerns.csproj", "Core/Core.CrossCuttingConcerns/"]
COPY ["Core/Core.Security/Core.Security.csproj", "Core/Core.Security/"]
COPY ["Core/Core.Persistence/Core.Persistence.csproj", "Core/Core.Persistence/"]
COPY ["Services/ContactAPI/Contact.API.Infrustructure/Contact.API.Infrustructure.csproj", "Services/ContactAPI/Contact.API.Infrustructure/"]
COPY ["Services/ContactAPI/Contact.API.Models/Contact.API.Models.csproj", "Services/ContactAPI/Contact.API.Models/"]
COPY ["Services/ContactAPI/Contact.API.Services/Contact.API.Services.csproj", "Services/ContactAPI/Contact.API.Services/"]
RUN dotnet restore "Services/ContactAPI/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/ContactAPI/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]