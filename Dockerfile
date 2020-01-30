FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir /app
WORKDIR /app

COPY webapi.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

EXPOSE 5000/tcp
CMD ["dotnet", "out/webapi.dll"]
