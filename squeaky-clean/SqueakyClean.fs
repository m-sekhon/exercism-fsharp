module SqueakyClean

open System

let transformToKebabCase (input: string) : string =
    input 
    |> Seq.map (fun c -> if Char.IsUpper(c) then ["-"; Char.ToLower(c) |> string] else [string c])
    |> Seq.collect id
    |> String.concat ""    
    
let isCamelCase(c: char) =
    Char.IsUpper(c)
    
let isNumeric(c:char) =
    Char.IsDigit(c)

let transform (c: char) : string =
  if isCamelCase c then transformToKebabCase (c |> string)
    else
        match c with
        | '-' -> "_"
        | ' ' -> ""
        | _ when Char.IsDigit(c) -> ""
        | _ when c >= 'α' && c <= 'ω' -> "?" // Replace Greek letters with a dash
        | _ -> string c

let clean (identifier: string) : string =
     identifier 
    |> Seq.map transform 
    |> String.concat ""
