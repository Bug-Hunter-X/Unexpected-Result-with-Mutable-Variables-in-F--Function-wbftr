let add (x, y) = x + y

let mutable x = 10
let mutable y = 20

let z = add (x, y)
printfn "%d" z
x <- 100
y <- 200
let z2 = add (x,y)
printfn "%d" z2