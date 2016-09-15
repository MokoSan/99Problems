// Question 14
// Duplicate the elements of a list

let rec duplicate0 ( l : 'a List ) : 'a List = 
    match l with
    | [] -> []
    | x :: xs -> x :: x :: duplicate0 xs

duplicate0 [1;2;3]