// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


let testList = [2..100]


let rec sieve = function
    | (p::xs) -> p :: sieve [ for x in xs do if x % p > 0 then yield x ]
    | []      -> []


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let primes = sieve testList
    printfn "%A" primes 

    0 // return an integer exit code

