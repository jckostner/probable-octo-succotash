/*DROP TABLE IF EXISTS actorMovies;
DROP TABLE IF EXISTS directorIDs;
DROP TABLE IF EXISTS directorMovies;
DROP TABLE IF EXISTS reveiwers;
DROP TABLE IF EXISTS reviews;
DROP TABLE IF EXISTS soundTracks;
DROP TABLE IF EXISTS movies;
DROP TABLE IF EXISTS genres;
DROP TABLE IF EXISTS countries;
DROP TABLE IF EXISTS actorIDs;
DROP TABLE IF EXISTS companies;*/

CREATE TABLE genres(
     genreID                  INT NOT NULL,
     genre                    varchar(20) NOT NULL,
	 PRIMARY KEY(genreID)
);

CREATE TABLE countries(
     countryID                INT NOT NULL,
     name                     varchar(20) NOT NULL,
     PRIMARY KEY(countryID)
);

CREATE TABLE actorIDs(
     actorID                       INT NOT NULL,
     name                     varchar(30) NOT NULL,
     PRIMARY KEY(actorID)
);

CREATE TABLE companies(
     companyID                      int NOT NULL,
     name                     varchar(20) NOT NULL,
     address                  varchar(30) NOT NULL,
     PRIMARY KEY(companyID)
);

CREATE TABLE movies(
     movieID                  INT NOT NULL,
     releaseDate              DATETIME NOT NULL,
     name                     varchar(50) NOT NULL,
     movielength              INT NOT NULL,
	 gID 					  INT,
     FOREIGN KEY(gID) 	  REFERENCES genres(genreID),
	 cID					  INT,
     FOREIGN KEY(cID)         REFERENCES companies(companyID),
	 producedIn               INT,
     FOREIGN KEY(producedIn)  REFERENCES countries(countryID),
	 PRIMARY KEY(movieID)
);

CREATE TABLE actorMovies(
     actorMovieID 			  INT,
	 FOREIGN KEY(actorMovieID)          REFERENCES actorIDs(actorID),
	 movID 				  	  INT,
     FOREIGN KEY(movID)         REFERENCES movies(movieID),
     PRIMARY KEY(actorMovieID, movID)
);

CREATE TABLE directorIDs(
     directorID                       int NOT NULL,
     name                     varchar(30) NOT NULL,
     PRIMARY KEY(directorID)
);

CREATE TABLE directorMovies(
	 directorMovieID 					  INT,
     FOREIGN KEY(directorMovieID)         REFERENCES directorIDs(directorID),
	 movID 			      INT,
     FOREIGN KEY(movID)     REFERENCES movies(movieID),
     PRIMARY KEY(directorMovieID, movID)
);

CREATE TABLE reviewers(
     reviewerID                       INT NOT NULL,
     name                     varchar(30) NOT NULL,
	 company 				  INT,
     FOREIGN KEY(company)     REFERENCES companies(companyID),
     PRIMARY KEY(reviewerID)
);

CREATE TABLE soundTracks(
	 movID				  INT,
     FOREIGN KEY(movID)     REFERENCES movies(movieID),
     title                    varchar(30) NOT NULL,
     releaseDate              int NOT NULL,
     numTracks                int 
);

CREATE TABLE review(
	rID 				  INT,
	FOREIGN KEY(rID)   REFERENCES reviewers(reviewerID),
	movID					  INT,
	FOREIGN KEY(movID)      REFERENCES movies(movieID),
	rating					  INT NOT NULL,
	reviewDate 				  INT NOT NULL,
	PRIMARY KEY(rating)
);
