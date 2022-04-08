FROM node:16.14.2-alpine
WORKDIR /app
COPY ./package.json /app
RUN npm i -g @angular/cli @angular-devkit/build-angular
RUN yarn
EXPOSE 4200
COPY . .
