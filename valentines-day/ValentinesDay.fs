module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller
    
type Activity  =
    | BoardGame
    | Chill 
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity) : Approval =   
    match activity with
    | BoardGame -> Approval.No
    | Chill -> Approval.No
    | Movie Genre.Romance -> Approval.Yes
    | Movie Genre.Horror -> Approval.No
    | Movie Genre.Thriller -> Approval.No
    | Movie Genre.Crime -> Approval.No
    | Restaurant Cuisine.Korean -> Approval.Yes
    | Restaurant Cuisine.Turkish -> Approval.Maybe
    | Walk d when d<3  -> Approval.Yes
    | Walk d when d<5  -> Approval.Maybe    
    | Walk d -> Approval.No
    