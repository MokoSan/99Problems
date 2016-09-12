// Question 1
// Last element of a list

exception EmptyListException of string

let rec lastElement0 ( l : 'a List ) : 'a = 
    match l with
    | x :: [] -> x
    | x :: xs -> lastElement0( xs ) 
    | _ -> raise (EmptyListException("Empty List as an input!")) 

let lastElement1 ( l : 'a List ) : 'a = 
    match l with
    | [] -> raise (EmptyListException("Empty List as an input!")) 
    | x -> x |> List.rev |> List.head

(* Tests *)
lastElement0 [1;2;3;] = 3 
lastElement1 [1;2;3;] = 3