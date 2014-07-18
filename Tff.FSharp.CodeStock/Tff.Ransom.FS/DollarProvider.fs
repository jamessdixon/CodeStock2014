namespace Tff.Ransom.FS

open System
 
type dollar =
    {id: int;
     serialNumber: string;
     federalReserveDistrict: int;
     seriesDate: int;
     signature: string}

type dollarProvider() =
    let randomNumberGenerator = new System.Random()
    
    let createSerialNumber id = 
        List.init 9 (fun _ -> randomNumberGenerator.Next(0,9))
                                |> Seq.map string
                                |> String.concat ""
    let createDollar id serialNumber=
        let returnDollar = {id=id;
            serialNumber= serialNumber;
            federalReserveDistrict=randomNumberGenerator.Next(0,13);
            seriesDate=2000+randomNumberGenerator.Next(0,9);
            signature=""}
        returnDollar

    member this.GetDollars (numberOfDollars:int) =
        let dollars = List.init numberOfDollars (fun index -> createDollar index)
        let serialNumbers = List.init numberOfDollars (fun index -> createSerialNumber index)
        List.zip dollars serialNumbers
