// Question 7
// Flatten a nested list structure

type 'a node =
    | One of 'a 
    | Many of 'a node list

let rec flattenList0 ( l : 'a List ) : 'a List = 
    match l with
    | One x -> [ x; ]
    | Many x -> List.collect flattenList0 x