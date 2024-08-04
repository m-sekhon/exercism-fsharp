module PerfectNumbers

type Classification = Perfect | Abundant | Deficient 

let isPerfectNum n =
    let divisors = [1..n-1] |> Seq.filter (fun x -> n % x = 0)
    let divisorSum = Seq.sum divisors
    
    divisorSum = n

let isAbundantNum n =
    let divisors = [1..n-1] |> Seq.filter (fun x -> n % x = 0)
    let divisorSum = Seq.sum divisors
    divisorSum > n

let isDeficientNum n =
    let divisors = [1..n-1] |> Seq.filter (fun x -> n % x = 0)
    let divisorSum = Seq.sum divisors
    divisorSum < n

let classify n : Classification option =
    match n with
    | _ when n < 1 -> None
    | _ when isPerfectNum n -> Some Classification.Perfect
    | _ when isAbundantNum n -> Some Classification.Abundant
    | _ when isDeficientNum n -> Some Classification.Deficient
    | _ -> None
    

