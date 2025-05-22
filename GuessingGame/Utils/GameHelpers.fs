namespace GuessingGame.Utils.GameHelpers

open System

module GameHelpers = 
    let getRamdomInteger(minValue: int)(maxValue: int): int =
        let ramdom = Random()
        ramdom.Next(minValue, maxValue)

    // Refactor this function to manage try/catch
    let printMessagesToConsole(message: string): unit =
        System.Console.WriteLine(message)

    // Check if it is <null> (empty)
    // Check for <whitespaces> shoulnd't be allowed
    // Since command inputs are strings, I need to parse the number 
    let parseInputToInteger(str: string): option<int> =
        match System.Int32.TryParse(str) with
        | (true, int) -> Some(int)
        | _ -> None
    
    
    let rec commandLineInput(command: unit): string = 
        let input = System.Console.ReadLine()
        match input with
        | s when String.IsNullOrWhiteSpace(s) ->
            printMessagesToConsole("Please enter a valid number")
            commandLineInput()
        | _ -> input

    
    // Must create a validate answer function
    // that will be a match expression to validate
    // the user input/output answer


