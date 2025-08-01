// Opening modules to access data and logic
open Data.Movies
open Logic.OscarFilter
open Logic.RunLengthConverter

[<EntryPoint>]
let main argv =
    // Applying filter to find probable Oscar winners
    let winners = probableWinners movieList  // filtering based on IMDB 

    // Converting run lengths to "Xh Ymin" format
    let formattedTimes = convertRunLengths movieList  // doing a map transformation 

    // Displaying winners
    printfn "🏆 Probable Oscar Winners (IMDB > 7.4):"
    winners |> List.iter (fun m -> 
        printfn "- %s (Rating: %.1f)" m.Name m.IMDBRating  // labelling with movie name and rating
    )

    // Showing converted runtime formats
    printfn "\n🕒 Movie Run Times in Hour:Minute Format:"
    formattedTimes |> List.iter (printfn "%s")  // printing each converted runtime

    // Final return value for the main entry point
    0  
