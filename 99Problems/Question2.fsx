// Question 2
// Second Last Element of a List

exception EmptyListException      of string
exception OneElementListException of string

let rec secondLastElement0 ( l : 'a List ) : 'a =    
    match l with
    | [] -> raise (EmptyListException("Empty list as an input"))
    | [ x ] -> raise (OneElementListException("List too short to get the 2nd last element."))
    | x :: _ :: [] -> x 
    | _ :: xs -> secondLastElement0(xs)

let secondLastElement1 ( l : 'a List ) : 'a = 
    match l with
    | [] -> raise (EmptyListException("Empty list as an input"))
    | [ x ] -> raise (OneElementListException("List too short to get the 2nd last element."))
    | x -> x |> List.rev |> List.tail |> List.head

(* Tests *)
secondLastElement0 [1;2;3;4] = 3 
secondLastElement1 [1;2;3;4] = 3