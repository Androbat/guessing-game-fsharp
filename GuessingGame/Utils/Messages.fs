module GuessingGame.Utils.Messages

open System

// <Welcome> message will come from here

module Message = 
    let welcomeMessage(): string =
        "-----------------------------------------------\n" +
        "       WELCOME TO THE GUESSING GAME!\n" +
        "-----------------------------------------------\n" 

    let ruleList(): string =
        "-----------------------------------------------\n" +
        "            RULES OF THE GAME                  \n" +
        "-----------------------------------------------\n" +
        "1. You have to guess a number between 1 and 100.\n" +
        "2. You have to choose a difficulty level.        \n" +
        "3. You have to guess the number in the least amount of attempts.                                \n" +
        "4. You will be given hints if you are close to the number. 
                                      \n" +
        "                   Have fun!                  \n" +
        "-----------------------------------------------\n" +
        "                    LEVEL                       \n" +
        "-----------------------------------------------\n" +
        "           1. Easy (10 attempts)               \n" +
        "           2. Medium (7 attempts)              \n" +
        "           3. Hard (5 attempts)                \n" +
        "-----------------------------------------------\n" 