module FSharpExercise.Program

open FSharpExercise.Integral
open FSharp.Stats.Integration
open System.Diagnostics

[<EntryPoint>]
let main (args:string array) :int =
    
    let left = 0.0
    let right = 1.0
    let n = pown 2 23
    
    let mutable stopwatch = Stopwatch.StartNew()
    let myIntegral = Integrate Sinus left right n
    stopwatch.Stop()
    printfn $"My integral =  {myIntegral}.\nTime elapsed = {stopwatch.Elapsed}"
    
    stopwatch <- Stopwatch.StartNew()
    let libIntegral = Sinus |> NumericalIntegration.definiteIntegral(Midpoint, left, right, n)
    stopwatch.Stop()
    printfn $"Lib integral = {libIntegral}.\nTime elapsed = {stopwatch.Elapsed}"
    
    0 // Return 0. This indicates success.
