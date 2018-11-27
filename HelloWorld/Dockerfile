FROM ubuntu:latest

RUN apt-get update
RUN apt-get install -y vim
RUN apt-get install -y apache2

ADD index.html /var/www/html/index.html
EXPOSE 80
CMD service apache2 start && /bin/bash

