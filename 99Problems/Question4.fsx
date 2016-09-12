// Question 4
// Count elements in a list

let rec listLength0 ( l : 'a List ) : int =
    match l with
    | [] -> 0
    | x :: xs -> 1 + listLength0( xs )

let listLength1 ( l : 'a List ) : int = 
    let rec loop ( acc : int ) ( l' : 'a List ) : int = 
        match l' with
        | [] -> acc
        | x :: xs -> loop ( acc + 1 ) xs
    loop 0 l