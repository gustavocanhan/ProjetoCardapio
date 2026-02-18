FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /src

COPY . .

RUN dotnet restore

EXPOSE 5254

ENV ASPNETCORE_URLS=http://+:5254

CMD ["sh", "-c", "dotnet tool install --global dotnet-ef && export PATH=$PATH:/root/.dotnet/tools && dotnet ef database update && dotnet run --urls http://0.0.0.0:5254"]
