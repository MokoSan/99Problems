// Question 20
// Remove the K'th element from a list

let removeKthElement0 ( list : 'a List ) ( k : int ) : 'a List = 
    if list = [] then []
    else list |> List.mapi(fun i x -> i + 1, x)
              |> List.filter(fun x -> fst (x) <> k)
              |> List.map(fun x -> snd x)