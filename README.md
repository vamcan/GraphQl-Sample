# GraphQl-Sample DotnetCore HotChocolate
## Overview

This project is a .NET Core web API that uses the HotChocolate and HotChocolate.Data libraries to provide a GraphQL endpoint for querying movie data.


## Classes
The following classes are included in this project:

Actor
This class represents an actor in a movie and has the following properties:

FirstName: the first name of the actor
LastName: the last name of the actor 
Movie
This class represents a movie and has the following properties:

Id: the unique identifier for the movie
Title: the title of the movie
Actors: a list of Actor objects representing the actors in the movie
Query
This class contains the methods that can be queried through the GraphQL endpoint. It has the following methods:

GetMovies: returns a list of all movies in the system
GetMovieById: takes an id parameter and returns the movie with the corresponding Id property, or null if no such movie exists
Seed
This class contains a method called SeedData which returns a list of movies with predetermined Actor and Movie objects. This method is used to seed the data for the GraphQL endpoint.



## Usage
To use this project, you will need to have .NET Core installed on your machine.

Clone or download the project onto your local machine.
Navigate to the project directory in a terminal window.
Run the command dotnet run to start the API.
The GraphQL endpoint will be available at https://localhost:7296/graphql. You can use a tool like GraphQL Playground to issue queries to the endpoint.



## Example Queries

Here are some example queries that you can use with this GraphQL endpoint:

## Get a list of all movies

```sh
query {
  getMovies {
    id
    title
  }
}

```
## Get a specific movie by its id

```sh
query {
  getMovieById(id: 1) {
    id
    title
    actors {
      firstName
      lastName
    }
  }
}

```
