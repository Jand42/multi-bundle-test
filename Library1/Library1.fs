namespace Library1

open WebSharper

[<JavaScript>]
type UsedIn1() = 
    member this.X = "UsedIn1"
    
[<JavaScript>]
type UsedIn2() = 
    member this.X = "UsedIn2"
    
[<JavaScript>]
type UsedIndirectlyIn2() = 
    member this.X = "UsedIndirectlyIn2"

[<JavaScript>]
type UsedIn1And2() = 
    member this.X = "UsedIn1And2"