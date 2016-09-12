// Question 6
// Is Palindrome list

let isPalindrome0 ( l : 'a List ) : bool = 
    let revList = List.rev l
    revList = l