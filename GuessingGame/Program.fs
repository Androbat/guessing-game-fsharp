// For more information see https://aka.ms/fsharp-console-apps
namespace GuessingGame

open System

open GuessingGame.Utils.Dificulty
open GuessingGame.Utils.GameHelpers
open GuessingGame.Utils.Messages

module Program =
    [<EntryPoint>]
    let main argv =
        let welcome = Message.welcomeMessage()
        let rules = Message.ruleList()
        let messagesList = [welcome; rules] 

        messagesList
        |> List.iter(fun message ->
            System.Console.WriteLine(message)
        )

        System.Console.WriteLine("Choose a level: ")
        let levelPicked = GameHelpers.commandLineInput()
        let parseInput = GameHelpers.parseInputToInteger(levelPicked)
        
         



        
        0