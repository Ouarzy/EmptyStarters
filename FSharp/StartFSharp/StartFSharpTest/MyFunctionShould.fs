namespace StartFSharpShould

open Xunit
open FsUnit.Xunit
open Basket

module ``I write a first test`` =

    [<Fact>]
    let ``the test should failed``() =
        trueFunction |> should equal false
