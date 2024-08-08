module Pangram

open System

let isPangram (input: string): bool =
    if String.IsNullOrEmpty(input) then false
    else
       let alphabet = "abcdefghijklmnopqrstuvwxyz"
       let lowerCaseInput = input.ToLower()   
       alphabet |> Seq.forall (fun c -> lowerCaseInput.Contains(c.ToString()))
    