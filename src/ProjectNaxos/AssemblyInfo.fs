﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ProjectNaxos")>]
[<assembly: AssemblyProductAttribute("Naxos")>]
[<assembly: AssemblyDescriptionAttribute("Project Naxos")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
