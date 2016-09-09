namespace Sainte_Lague_FSharp

type Party = { 
    PartyName : string
    ElectorateSeats : int
    Votes : int 
    mutable ListSeats : int
}
    

module Election = 
    let totalVotes (parties : Party list) =
        let rec sum values accum =
            match values with
            | [] -> accum
            | head :: tail -> sum tail (accum + head.Votes)
        sum parties 0
    let partyQualifideForParlement party tv = 
        let overFivePercent party tv = 
            (float)party.Votes / (float)tv > 0.05
        let partyGotMoreThanOneElectorateMP party =
            party.ElectorateSeats > 0
        overFivePercent party tv || partyGotMoreThanOneElectorateMP party
    let EligibilityFilter (parties : Party list) =
        let tv = totalVotes parties
        printfn "Total votes: %i" tv
        for party in parties do
            let q = partyQualifideForParlement party tv
            if q then printfn "%s qualifide for parliment!!" party.PartyName
//            printfn "Party: %s Votes: %i Elecotate seats won: %i" party.PartyName party.Votes party.ElectorateSeats

        
