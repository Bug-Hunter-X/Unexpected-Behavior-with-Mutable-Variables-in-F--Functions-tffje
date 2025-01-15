let x = 10
let y = 20

let add x y = 
    let newX = x + y
    let newY = y + newX
    (newX, newY)

let (updatedX, updatedY) = add x y
printf "%d %d" updatedX updatedY