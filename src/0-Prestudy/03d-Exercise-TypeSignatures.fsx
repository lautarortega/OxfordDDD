// =============================================
// Exercise:
//
// For each of the following definitions,
// say whether it is a simple value or a function,
// and if a function, what is the function signature?
//
// NOTE: I have commented these out because if you are using VS Code or Rider,
// you will see the answers already!
//
// To check your answer, uncomment and run them.
//
// In all cases, make sure you understand WHY the signatures
// are what they are.
// =============================================

// Simple value or function?
// If a function, what is the function signature?
// let testA = 2
// simple value

// Simple value or function?
// If a function, what is the function signature?
// let testB x = 2 + x
// function because there is a param, 2 is int so x needs to be int

// let testC x = 2.0 + x
// function float -> float

// let testD = "hello"
// simple value

// let testE = printfn "hello"
// simple value unit

// let testF () = 42
// function unit -> int

// let testG () = printfn "hello"
// function unit -> unit

// let testH x = String.length x
// function string -> int

// let testI x = sprintf "%i" x
// function int -> string

// let testJ x = printfn "%i" x
// function int -> unit

// let testK x =
//     printfn "x is %f" x
//     x  // return x
// function float -> float

// let testL (f:int -> string) x =
//     f x
// function f: (int -> string) -> x: int -> string
// val testL: f: (int -> string) -> x: int -> string


let testM f (x:int) :string =
    f x
// val testM: f: (int -> string) -> x: int -> string

// Trick question! Hint: what does :string modify?
// let testN x :string = x 1
// it modifies the output, we need to return a string then x needs to be a function that receives ints and returns strings
// let testO x = 1
// value

// hint: what kind of thing is x?
// let testP x = x 1
// it has to be a function, int -> 'a

// let testQ x y = x
// function 'a 'b 'a

// let testR x y z = z
// function 'a 'b 'c 'c

// let testS x = (x=x)
// function 'a -> bool


// =============================================
// Exercise:
//
// For each of the following signatures, create a function
// that will be *inferred* to have that signature.
//
// Avoid using explicit type annotations!
// =============================================

// val sigA = int -> int

// Here's an example of a possible answer for "sigA":
(*
let sigA x = x + 1
*)

// val sigB = int -> unit

// Here's an example of a possible answer for "sigB":
(*
let sigB x = printfn "%i" x
*)

// val sigC = int -> string
let sigC x = sprintf "I have %i bananas" x 

// val sigD = unit -> string
let sigD () = "Hello World"

// val sigE = string -> string
let sigE name = sprintf "Hello %s" name

// val sigF = int -> bool -> float -> string
let sigF x y z =
    if x>3 && y then
        string (float x / z)
    else
        "False"

// =============================================
// Exercise:
//
// Make the following functions compile by adding
// type annotations. Try to use the minimum annotations possible!
//
// Reminder of how to do type annotations
// let aFunction (param1:string) (param2:bool) :string =
//                ^1st param      ^2nd param    ^return type
//
// =============================================

// Remove spaces from front and back of a string
// The "s" parameter is a string and it returns a string
let trim (s:string) = s.Trim()

// Return the length of string
// The "s" parameter is a string and it returns an int
let len (s:string) = s.Length

// Replace a substring with new substring
// The s, oldStr,newStr parameters are all string
// and it returns a string
let replace (oldStr:string) (newStr:string) (s:string) :string = s.Replace(oldStr,newStr)
(*
This one is tricky because .NET has two overloads
  Replace(string,string)
  Replace(char,char)
So we need to say what type the parameters are too.
*)


// =============================================
// Exercise (HARD):
// Below are four generic signatures.
// Try to create four functions that are inferred to have these signatures.
//
// Avoid using explicit type annotations!
// =============================================

// val sigW = 'a -> int
let sigW x =
    if x=x then
        1
    else
        0

// val sigX = int -> 'a
// let sigX x = // this was a trick question, no ans possible


// val sigY = 'a -> 'a
let sigY x = x

// val sigZ = 'a -> 'b
// Also impossible
