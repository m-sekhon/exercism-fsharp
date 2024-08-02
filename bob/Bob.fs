module Bob

open System

let isNullOrEmpty (str: string) = String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str)

let isUppercase (str: string) =
    // removing spaces and special characters using Regex.
    let regex = System.Text.RegularExpressions.Regex("[^A-Z]", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
    let newStr = regex.Replace(str, "")

    // Checking if the remaining string is in uppercase.
    String.Equals(newStr, newStr.ToUpper())
    

let isQuestion (str: string) = str.Trim().EndsWith("?")



let response (input: string): string =
    let isUpperCaseResult = isUppercase input
    let isQuestionResult = isQuestion input
    let isNullOrEmptyResult = isNullOrEmpty input
    if isUpperCaseResult && isQuestionResult then "Calm down, I know what I'm doing!"
    elif isQuestionResult then "Sure."
    elif isUpperCaseResult then "Whoa, chill out!"
    elif isNullOrEmptyResult then "Fine. Be that way!"
    else "Whatever."
