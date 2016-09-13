// Question 10
// Run-length encoding of a list.

// we use the answer in Q9 to help us out.
let packDuplicates0 l = 
    let collectDuplicates x = function
        | ( y :: xs ) :: ys when x = y -> ( x :: y :: xs ) :: ys
        | xss -> [x] :: xss
    List.foldBack collectDuplicates l []

let encode0 ( list : 'a List ) : 'b List = 
    list 
    |> packDuplicates0 
    |> List.map(fun xs -> List.length xs, List.head xs)