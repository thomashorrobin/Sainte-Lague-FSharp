namespace Sainte_Lague_FSharp

type Party = { 
    PartyName : string
    ElectorateSeats : int
    Votes : int 
    mutable ListSeats : int
}

type Party with
    member x.TotalSeats = 
        let mutable totalSeats = x.ListSeats
        if totalSeats < x.ElectorateSeats then
            totalSeats <- x.ElectorateSeats
        totalSeats
    

module Election = 
    let private partyQualifideForParlement party tv = 
        let overFivePercent party tv = 
            (float)party.Votes / (float)tv > 0.05
        let partyGotMoreThanOneElectorateMP party =
            party.ElectorateSeats > 0
        overFivePercent party tv || partyGotMoreThanOneElectorateMP party
    let quot party = (float)party.Votes / (float)(2 * party.ListSeats + 1)
    let nextQuot parties = List.maxBy(fun p -> quot p) parties
    let RunElection (parties : Party list) (listSeats : int) =
        let tv = List.sumBy (fun p -> p.Votes) parties
        let eligibleParties = List.filter (fun p -> partyQualifideForParlement p tv) parties 
        for i = 1 to listSeats do
            let p = nextQuot eligibleParties
            p.ListSeats <- p.ListSeats + 1
        eligibleParties

        
