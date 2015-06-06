namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("SeatBooking")>]
[<assembly: AssemblyProductAttribute("SeatBooking")>]
[<assembly: AssemblyDescriptionAttribute("SeatBooking Dummy System")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
