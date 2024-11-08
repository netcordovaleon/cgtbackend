FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY Sgt.App/*.csproj ./Sgt.App/
COPY Sgt.Application/*.csproj ./Sgt.Application/
COPY Sgt.Persistence/*.csproj ./Sgt.Persistence/
COPY Sgt.Domain/*.csproj ./Sgt.Domain/
COPY Sgt.Shared/*.csproj ./Sgt.Shared/

#
RUN dotnet restore 
#
# copy everything else and build app
COPY Sgt.App/. ./Sgt.App/
COPY Sgt.Application/. ./Sgt.Application/
COPY Sgt.Persistence/. ./Sgt.Persistence/
COPY Sgt.Domain/. ./Sgt.Domain/
COPY Sgt.Shared/. ./Sgt.Shared/

#
WORKDIR /app/Sgt.App
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/Sgt.App/out ./
ENTRYPOINT ["dotnet", "Sgt.App.dll"]