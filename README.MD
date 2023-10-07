# Headless WordPress with Blazor frontend

Frontend build with Blazor, using Wordpress, running on .NET, as a headless CMS,

Pre-configured for a containerized development environment using Docker Compose

Watch [Demo Video](https://www.youtube.com/watch?v=21eOnKgJSWE)

## Features
* List excerpts of posts, and view full posts.
* Display a Menu/Navigation that has been defined in Wordpress.

## Acknowledgements

Thanks to the guys at [Iolevel](https://www.iolevel.com/), and the community, for the wonderful [Peachpie](https://www.peachpie.io/) PHP compiler, and [Wordpress.NET](https://www.wpdotnet.com/).

And a special thanks to the Wordpress community for this awesome ecosystem

## Screenshots
### Frontend (Blazor)

| Index         | Post         |
| ------------- | --------------|
| <img src="/Screenshots/Index.png" /> | <img src="/Screenshots/Post.png" />

## Run the app with Docker Compose

This is the simplest way of running this project.

But you need to do the necessary configuration of Wordpress.

```sh
$ docker compose up -d
```

The Blazor Frontend is served at: ```https://localhost:5001/```

While Wordpress is at: ```https://localhost:5005/```.


### Tip

** This seem to break the Gutenberg Editor since it is using the setting when sending requests to Wordpress. **

For convenience, you can change the ```Site Address (URL)``` in WP Admin ```(Settings > General)``` to be the address of the frontend. Now the links in WP Admin that lead to the frontend will be correct.

## Manual installation

### Create MySQL database

WordPress requires you to start your database server with a database in it. By default it expects a database server on localhost, port 3306, with a database named *"wordpress"*.

You can use *docker* to quickly start a database server in virtual environment:
```
docker run -e MYSQL_ROOT_PASSWORD=password -e MYSQL_DATABASE=wordpress -p 3306:3306 -d mysql
```

## Build &amp; Run

Note, this is a regular ASP.NET web project. Building, running, debugging, and deploying the site take advantage of `dotnet`, optionally Visual Studio.

```
dotnet run
```

# Configuration

The configuration itself serves as a demonstration of combining a legacy PHP application with .NET. The demo takes advantage of the ASP.NET Core configuration mechanism, namely the files `appsettings.json`, `appsettings.deployment.json` and `appsettings.production.json`. This allows for having a different configuration for each environment without the need of altering the source code of the project.

More on configuring WpDotNet on https://docs.peachpie.io/scenarios/wordpress/configuration/.
