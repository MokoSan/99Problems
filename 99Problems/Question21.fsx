// Question 21
// Insert an element at a given position into a list

exception EmptyListException of string

let rec insertElementAt ( list : 'a List ) ( x : 'a ) ( i : int ) : 'a List = 
    match list, i with
    | [], 1 -> [ x ]
    | [], _ -> raise (EmptyListException("list is empty!")) 
    | _, 1 -> x :: list 
    | y :: ys, n -> insertElementAt ys x (n - 1) 