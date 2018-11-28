FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .

COPY MongoTest/*.csproj ./MongoTest/
RUN dotnet restore MongoTest

# copy everything else and build app
COPY MongoTest ./MongoTest/

WORKDIR /app/MongoTest
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime

WORKDIR /app
COPY --from=build /app/MongoTest/out ./

EXPOSE 80

# Mongo 
RUN apt-get update && apt-get install -y mongodb
RUN apt-get install -y vim
RUN update-rc.d mongodb enable
COPY ./mongodb.conf /etc/

CMD /usr/sbin/service mongodb start && /usr/bin/dotnet MongoTest.dll