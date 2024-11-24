FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build-env
WORKDIR /app
EXPOSE 8089
EXPOSE 443


COPY BlazorWasm.csproj ./
RUN dotnet restore
COPY . ./

RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM caddy:2.9-alpine AS final
WORKDIR /usr/share/caddy
COPY --from=build-env /app/publish/wwwroot ./

