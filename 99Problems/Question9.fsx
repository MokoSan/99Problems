// Question 9
// Pack consecutive duplicates of list elements into sublists.

let packDuplicates0 l = 
    let collectDuplicates x = function
        | ( y :: xs ) :: ys when x = y -> ( x :: y :: xs ) :: ys
        | xss -> [x] :: xss
    List.foldBack collectDuplicates l []