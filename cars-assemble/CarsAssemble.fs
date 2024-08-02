module CarsAssemble

let successRate (speed: int): float =
     if speed = 0   then
         0
     elif speed >= 1 && speed <= 4  then
         1
     elif speed >= 5 && speed <= 8   then
         0.9
     elif speed = 9   then
         0.8
     elif speed = 10   then
         0.77
     else 1.0
     

let productionRatePerHour (speed: int): float =
    let sr = successRate speed
    sr * float speed * 221.00

let workingItemsPerMinute (speed: int): int =
    let sr = successRate speed
    (sr * float speed * 221.00) / 60.00
    |> int
