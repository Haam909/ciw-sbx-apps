# Built from the repo root (see .dockerignore): a dotnet component has no
# `path`, its project being relative to the root.
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY Directory.Build.props .
COPY src/Billing/Billing.csproj src/Billing/packages.lock.json src/Billing/
RUN dotnet restore src/Billing/Billing.csproj --locked-mode
COPY src/Billing/ src/Billing/
ARG VERSION=0.0.0-dev
RUN dotnet publish src/Billing/Billing.csproj -c Release --no-restore -o /app -p:Version=${VERSION}

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .
# The image's own non-root user; it listens on 8080 (ASPNETCORE_HTTP_PORTS).
USER $APP_UID
EXPOSE 8080
ENTRYPOINT ["dotnet", "Billing.dll"]
