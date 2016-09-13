// Question 7
// Flatten a nested list structure

type 'a node =
    | One of 'a 
    | List of 'a node list

let flattenList0 l =
    let rec loop acc l' = 
        match l' with
            | One x -> x :: acc
            | List x -> List.foldBack(fun x' acc -> loop acc x') x acc 
    loop [] l