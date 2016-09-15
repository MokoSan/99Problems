// Question 15
// Replicate the elements of a list a given number of times.

let replicate0 ( list : 'a List ) ( n : int ) : 'a List =
    list |> List.collect( List.replicate n )