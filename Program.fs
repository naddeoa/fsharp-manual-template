// Learn more about F# at http://fsharp.org

open System
open FSharp.Data
open FSharp.Data.JsonExtensions

type Config = JsonProvider<"/home/naddeo/.strokes.json">

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
