module TwoFer

let twoFer (input: string option) : string =
    if not input.IsNone then
        let result = "One for " + input.Value + ", one for me."
        result
    else
       let result = "One for you, one for me."
       result
    