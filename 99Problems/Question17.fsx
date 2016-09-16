// Question 17
// Split a list into two parts; the length of the first part is given.

let splitList0 ( list : 'a List ) ( n : int ) =
    let rec split1st xs n =
        match xs, n with
        | _, 0 -> []
        | [], _ -> []
        | x :: xs, n -> x :: (split1st xs (n - 1)) 
    let rec split2nd xs n =
        match xs, n with
        | xs, 0 -> xs
        | [], _ -> []
        | x :: xs, n -> (split2nd xs (n - 1))
    split1st list n, split2nd list n 