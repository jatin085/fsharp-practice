﻿(*
Simple Array Sum

Given an array of  integers, can you find the sum of its elements?

Input Format

The first line contains an integer, N, denoting the size of the array.
The second line contains N space-separated integers representing the array's elements.

Output Format

Print the sum of the array's elements as a single integer.

Sample Input

6
1 2 3 4 10 11

Sample Output

31

Explanation

We print the sum of the array's elements, which is: 1 + 2 + 3 + 4 + 10 + 11 = 31.
*)

open System

[<EntryPoint>]
let main _ =
    Console.ReadLine() |> ignore
    Console.ReadLine().Split [|' '|]
        |> Seq.map int
        |> Seq.sum
        |> printfn "%d"
    0