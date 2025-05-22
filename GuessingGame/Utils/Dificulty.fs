// The options -> are going to be a type of discriminated union
namespace GuessingGame.Utils.Dificulty

open System

module Level = 
    type Rules =
        | Easy of string
        | Medium of string
        | Hard of string
        

    let level(rule: Rules): string =
        match rule with
        | Easy value -> value
        | Medium value -> value
        | Hard value -> value
        | _ -> "INVALID LEVEL"

    let chooseLevel(levelPicked: string): int = 
        let attempts =
           match levelPicked with
           | "easy" | "Easy" | "EASY" -> 10
           | "medium" | "Medium" | "MEDIUM" -> 7
           | "hard" | "Hard" | "HARD" -> 5
           | _ -> 0
        attempts
        
        
