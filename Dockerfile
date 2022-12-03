FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

RUN dotnet workload install wasm-tools

