module ReverseString

open System

let isEmptyOrNull (input: string): bool = String.IsNullOrEmpty(input)
                                                               
let reverse (input: string): string =
    if isEmptyOrNull input
    then ""
    else new string(input.ToCharArray() |> Array.rev)
