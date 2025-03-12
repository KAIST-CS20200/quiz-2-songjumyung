module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let v = uint64 n
  let rec iter (value : uint64) cnt = 
    if value = (uint64 1) then cnt
    elif value % (uint64 2) = (uint64 0) then iter (value / (uint64 2)) cnt + 1
    else iter (value * (uint64 3) + (uint64 1)) cnt + 1
  iter v 0
