# Sample contents of Dockerfile
 # Stage 1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# caches restore result by copying csproj file separately
COPY *.csproj ./
RUN cd .. dotnet restore


 # copies the rest of your code
COPY . ./
RUN  cd .. dotnet publish -c Release -o dist   

 # Stage 2
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app

COPY --from=build-env /app/dist .

ENTRYPOINT ["dotnet", "WebApplication.dll"]
