// Question 5
// Reverse a list

let rec reverse0 ( l : 'a List ) : 'a List = 
    match l with
    | [] -> []
    | [ x ] -> [ x ]
    | x :: xs -> reverse0 ( xs ) @ [ x ]

let reverse1 ( l : 'a List ) : 'a List = 
    let rec loop ( acc : 'a List ) ( l' : 'a List ) : 'a List =
        match l' with
        | [] -> acc
        | x :: xs -> loop ( x :: acc ) xs 
    loop [] l  