module Gigasecond

open System

let gigasecond = 1000000000.0
let add (beginDate:DateTime) =    
    beginDate.AddSeconds(gigasecond)
