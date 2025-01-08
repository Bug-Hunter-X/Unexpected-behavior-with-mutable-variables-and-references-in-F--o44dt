let mutable x = 10
let y = &x
!y <- 20
printfn "%d" x //This will print 20

//However, if you do this:
let mutable x = 10
let y = ref x
!y <- 20
printfn "%d" x //This will still print 10

//The difference lies in how the compiler handles mutable variables and references.
//In the first example, &x creates a direct pointer to the mutable variable x, so modifying !y directly affects x.
//In the second example, ref x creates a reference cell that holds a copy of the value of x. Modifying !y changes the value within the reference cell, but not x itself.