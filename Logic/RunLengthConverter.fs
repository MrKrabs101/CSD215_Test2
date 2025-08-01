module Logic.RunLengthConverter
open Models.Movie

let formatRunLength minutes =
    let hours = minutes / 60
    let mins = minutes % 60
    $"{hours}h {mins}min"       // converting minutes into readable time string

let convertRunLengths (movies: Movie list) =
    movies
    |> List.map (fun m -> $"{m.Name}: {formatRunLength m.RunLength}")
