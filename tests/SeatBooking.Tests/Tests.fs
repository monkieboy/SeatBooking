module SeatBooking.Tests

open SeatBooking
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Seating.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)
