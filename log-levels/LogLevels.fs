module LogLevels

open System.Linq

let message (logLine: string) : string =
     let parts = logLine.Split(':')    
     if parts.Length < 2 then
        failwith "Invalid logLine format. It should contain ':' character."
     else
        parts.[1].Trim()

let logLevel (logLine: string) : string =
     let parts = logLine.Split(':')    
     if parts.Length < 2 then
        failwith "Invalid logLine format. It should contain ':' character."
     else
        let level = parts[0]
        let sanitised = level.Replace("[", "").Replace("]","")
        let result  = sanitised.Trim().ToLower()
        result

let reformat (logLine: string) : string =
     let parts = logLine.Split(':')    
     if parts.Length < 2 then
        failwith "Invalid logLine format. It should contain ':' character."
     else
        let level = logLevel(logLine)
        let m = message(logLine)
        let result = m + " (" + level + ")"
        result
