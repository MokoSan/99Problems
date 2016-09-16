// Question 18
// Extract a slice from a list given i, j

let sliceList0 ( list : 'a List ) ( i : int ) ( j : int ): 'a List =
    list |> List.mapi(fun i x -> i + 1, x)
         |> List.filter(fun x -> fst x < i && fst x > j) 
         |> List.map(fun x -> snd x )