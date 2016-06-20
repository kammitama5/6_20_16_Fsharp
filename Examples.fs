#light

open System

[<EntryPoint>]
let main argv = 
//Ask the user to enter how far they entered and write it to the console
    Console.Write("Please enter how far you travelled in kilometers: ")
//The entered value is read and stored into the value distance
    let distance = Console.ReadLine()
    let distance = float distance
//Ask the user to enter how much fuel (in gallons) they used
    Console.Write("Please enter how much fuel you used in gallons: ")
//The entered vaue is read and stored into he value fuel
    let fuel = Console.ReadLine()
    let fuel = float fuel
//Create the value Consumption, and let it be equal to distance divided by fuel
    let consumption = distance / fuel
//Write the output giving consumption based on calculation 
    Console.WriteLine("Your car does a distance of " + (string consumption) + 
    " per single unit of fuel")
    Console.ReadKey()
    0 // return an integer exit code
