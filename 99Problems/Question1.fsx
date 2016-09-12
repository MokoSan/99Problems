// Question 1
// Last element of a list

exception EmptyListError of string

let rec lastElement0 ( l : 'a List ) : 'a = 
    match l with
    | x :: [] -> x
    | x :: xs -> lastElement0( xs ) 
    | _ -> raise (EmptyListError("Empty List as an input!")) 

let lastElement1 ( l : 'a List ) : 'a = 
    match l with
    | [] -> raise (EmptyListError("Empty List as an input!")) 
    | x -> x |> List.rev |> List.head