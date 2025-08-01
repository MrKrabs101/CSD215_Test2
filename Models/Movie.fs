module Models.Movie

open Models.Genre
open Models.Director

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre            // using DU from Genre.fs
    Director: Director      // connecting nested record type
    IMDBRating: float
}
