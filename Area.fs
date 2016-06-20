#light

open System

//Ask the user to enter a width and height
Console.Write("Please enter a width: ")
let width = Console.ReadLine()
let width1 = float width


Console.Write("Please enter a height: ")
let height = Console.ReadLine()
let height1 = float height

let area = width1 * height1

Console.WriteLine("The area of the rectangle is " + (string area) + " metres ")


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
