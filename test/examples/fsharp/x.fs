// x.fs
// Sample source file to test F# syntax highlighting

[<AutoOpen>]
module Example

#line 7 "A compiler directive"
#if DEBUG
  open System
  open System.IO
  open System.Diagnostics
#endif

# 14 @"See: https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/strings#remarks"
// verbatim string
let xmlFragment1 = @"<book author=""Milton, John"" title=""Paradise Lost"">"

// triple-quoted string
let xmlFragment2 = """<book author="Milton, John" title="Paradise Lost">"""

(* you need .NET 5.0 to compile this:
  https://docs.microsoft.com/en-us/dotnet/fsharp/whats-new/fsharp-50#string-interpolation
*)
let interpolated = $"I think {3.0 + 0.14} is close to {System.Math.PI}!"

let ``a byte literal`` = '\209'B

// quoted expression
let expr =
    <@@
        let foo () = "bar"
        foo ()
    @@>

let bigNum (unused: 'a): float option =
    Seq.init 10_000 (float >> (fun i -> i + 11.))
    |> (List.ofSeq
        >> List.take 5
        >> List.fold (*) 1.0)
    |> Some

match bigNum () with
| Some num -> sprintf "%.2f > %u" num ``a byte literal``
| None -> sprintf "%A" "Have a byte string!"B
|> printfn "%s"