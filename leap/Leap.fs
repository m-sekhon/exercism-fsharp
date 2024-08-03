module Leap

let isDivisbleByFour(year: int) = 
    year % 4 = 0
    
let isDivisbleByHundred(year: int) = 
    year % 100 = 0

let isDivisbleByThree(year: int) = 
    year % 3 = 0

let leapYear (year: int): bool =
 if isDivisbleByFour(year) && not (isDivisbleByHundred(year))
    then true
    elif isDivisbleByHundred(year) && (year % 400 = 0)
    then true
    else false