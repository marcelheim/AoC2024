module AoC2024.Day1

open System

let input =
    System.IO.File.ReadAllLines "input/day1"
    |> Array.map (fun line ->
        let parts = line.Split("   ")

        match parts with
        | [| a; b |] -> (int a, int b)
        | _ -> failwith "Invalid input format")
    |> Array.unzip

let taskOne =
    let firstColumn, secondColumn = input

    let sortedFirst = Array.sort firstColumn
    let sortedSecond = Array.sort secondColumn

    Array.zip sortedFirst sortedSecond
    |> Array.sumBy (fun (a, b) -> Math.Abs(a - b))

let taskTwo =
    let firstColumn, secondColumn = input

    firstColumn
    |> Array.map (fun x -> secondColumn |> Array.filter ((=) x) |> Array.sum)
    |> Array.sum
