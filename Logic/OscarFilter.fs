module Logic.OscarFilter
open Models.Movie

// filtering movies with high enough IMDB rating
let probableWinners (movies: Movie list) =
    movies |> List.filter (fun m -> m.IMDBRating > 7.4)
