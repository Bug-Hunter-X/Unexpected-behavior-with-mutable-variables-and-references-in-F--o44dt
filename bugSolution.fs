let mutable x = 10
//Direct pointer using the & operator:
let y = &x
!y <- 20
printfn "%d" x //Prints 20 because y directly points to x

//Using ref to create a reference cell:
let mutable x2 = 10
let y2 = ref x2
!y2 <- 20
printfn "%d" x2 //Prints 10; Modifying !y2 only changes the value in the reference cell

//Explanation of difference:
//The & operator creates a direct pointer or alias to x, allowing changes to directly alter x
//ref x creates a reference cell, which contains a copy of the value. Changes to this cell do not change the original variable.