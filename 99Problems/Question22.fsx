// Question 22
// Create a list containing all integers within a given range

let listWithinARange0 ( a : int ) ( b : int ) : int List =
    [ a .. b ]

let listWithinARange1 ( a : int ) ( b : int ) : int List =
    seq { for i in a .. b -> i } |> Seq.toList