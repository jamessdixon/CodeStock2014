namespace Tff.FrequentFlyerCalculator.FS

open System

type Flight = {id: int; startCity: string; endCity: string; flightMiles: int; internationalFlight: bool}
type Customer = {id: int; name: string; isSilver: bool; isGold: bool; internationalTraveler: bool; joinDate: DateTime}

type CalculationEngine(flight: Flight, customer: Customer) = 
    member this.CalculateFrequentFlyerMiles = 
        let isLongStandingCustomer = 
            if customer.joinDate.Year - DateTime.Now.Year > 1 then true
            else false
        match isLongStandingCustomer, customer.isGold, customer.isSilver, customer.internationalTraveler, flight.internationalFlight, customer.name with
            | true,true,false,true,true,_ -> float flight.flightMiles * 1.5
            | true,false,true,true,true,_ -> float flight.flightMiles * 1.25
            | false,true,false,true,true,_ -> float flight.flightMiles * 1.05
            | false,false,true,true,true,_ -> float flight.flightMiles * 1.01
            | _,_,_,_,_,"The Boss" -> float flight.flightMiles * 1.3
            //| _,_,_,_,_,_ -> float flight.flightMiles 

