// Question 16
// Drop every N'th element from a list.

let dropNthElement0 ( list : 'a List ) ( n : int ) : 'a List = 
    let rec loop l n' =
        match l, n' with
        | [], _ -> []
        | _ :: xs, 1 -> loop xs n'
        | x :: xs, _ -> x :: loop xs ( n' - 1 ) 
    loop list n

let dropNthElement1 ( list : 'a List ) ( n : int ) : 'a List = 
    [0..list.Length + 1] 
    |> List.filter(fun i -> i % n <> 0 )
    |> List.collect(fun x -> [ list.[x] ])

let dropNthElement2 ( list : 'a List ) ( n : int ) : 'a List =
    list |> List.mapi(fun i x -> (i + 1, x))
         |> List.filter(fun (i, _) -> i % n <> 0 )
         |> List.map snd