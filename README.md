# DVDRental API

This is a test api that uses the DVDRental postgresql database.
I created this as a learning project for creating ASP.NET APIs.

## Setup and Run Locally

To start this locally you will need to [install docker](https://docs.docker.com/engine/install/), `cd` into this repo, and then run the script below to install the custom container.

```cmd
docker compose up
```

Once the container is running, you can build and debug this project. You can test the endpoints with built in Swagger at `http://localhost:5276/swagger/index.html` or install and use [Postman](https://www.postman.com/).

You can also deep dive into the database with PGAdmin at `localhost:5050` with username `admin@admin.com` and password `root`.
