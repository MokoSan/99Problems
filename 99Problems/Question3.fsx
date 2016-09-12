// Question 3
// Element at index

open System

let elementAtIndex0 ( l : 'a List ) ( idx : int ) : 'a = 
    if idx >= l.Length || idx < 0 
    then raise (System.IndexOutOfRangeException("idx out of range!")) 
    else l.[idx]