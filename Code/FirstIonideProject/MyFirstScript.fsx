let daysOfMonth = function
    | 2 -> 28
    | 4|6|9|11 -> 30
    | _ -> 31
;;

daysOfMonth 3;;

