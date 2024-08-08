module CollatzConjecture

let rec steps (number: int): int option =
    if number <= 0 then
        None
    else
        match number with
        | 1 -> Some 0
        | _ when number % 2 = 0 ->
            match steps (number / 2) with
            | Some n -> Some(n + 1)
            | None -> None
        | _ ->
            match steps (3 * number + 1) with
            | Some n -> Some(n + 1)
            | None -> None
