FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore", "--configfile", "nuget.config"]
RUN ["dotnet", "build"]
EXPOSE 5000/tcp
ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]
