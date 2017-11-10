CREATE TABLE movies(
     movieID                  int NOT NULL,
     releaseDate              datetime NOT NULL,
     name                     varchar(50) NOT NULL,
     length                   int NOT NULL,
     FOREIGN KEY(genre)       int REFERENCES genre.genreID,
     FOREIGN KEY(cID)         int REFERENCES companies.cID,
     FOREIGN KEY(producedIn)  int REFERENCES countries.countryID,
     PRIMARY KEY(movieID)
)

CREATE TABLE genres(
     genreID                  int NOT NULL,
     genre                    varchar(20) NOT NULL,
     PRIMARY KEY(genreID)
)

CREATE TABLE countries(
     countryID                int NOT NULL,
     name                     varchar(20) NOT NULL,
     PRIMARY KEY(countryID)
)

CREATE TABLE actorIDs(
     id                       int NOT NULL,
     name                     varchar(30) NOT NULL,
     PRIMARY KEY(id)
)

CREATE TABLE actorMovies(
     FOREIGN KEY(id)          int REFERENCES actorIDs.id,
     FOREIGN KEY(movieID)     int REFERENCES movies.movieID,
     PRIMARY KEY(id, movieID)
)

CREATE TABLE directorIDs(
     id                       int NOT NULL,
     name                     varchar(30) NOT NULL,
     PRIMARY KEY(id)
)

CREATE TABLE directorMovies(
     FOREIGN KEY(id)          int REFERENCES directorIDs.id,
     FOREIGN KEY(movieID)     int REFERENCES movies.movieID,
     PRIMARY KEY(id, movieID)
)

CREATE TABLE reviewers(
     id                       int NOT NULL,
     name                     varchar(30) NOT NULL,
     FOREIGN KEY(company)     int REFERENCES companies.cID,
     PRIMARY KEY(id)
)

CREATE TABLE reviews(
     FOREIGN KEY(reviewer)    int REFERENCES reveiwers.id,
     FOREIGN KEY(moviesID)    int REFERENCES movies.movieID,
     rating                   int NOT NULL,
     reviewDate                     datetime NOT NULL,
     PRIMARY KEY(reviewer, moviesID)
)

CREATE TABLE companies(
     cID                      int NOT NULL,
     name                     varchar(20) NOT NULL,
     address                  varchar(30) NOT NULL,
     PRIMARY KEY(cID)
)

CREATE TABLE soundtracks(
     FOREIGN KEY(movieID)     int REFERENCES movies.movieID,
     title                    varchar(50) NOT NULL,
     releaseDate              datetime NOT NULL,
     numTracks                int 
     PRIMARY KEY(movieID)
)
