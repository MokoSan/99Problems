// Question 8
// Unique elements from a list

let distinctList0 ( l : 'a List ) : 'a List =
    List.distinct l

let distinctList1 ( l : 'a List ) : 'a List =
    l |> Set.ofList |> Set.toList 