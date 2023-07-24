FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

RUN curl -sL https://deb.nodesource.com/setup_18.x | bash -
RUN apt-get install -y nodejs

ENTRYPOINT ["dotnet", "watch", "run", "--project", "Application/Application.csproj"]