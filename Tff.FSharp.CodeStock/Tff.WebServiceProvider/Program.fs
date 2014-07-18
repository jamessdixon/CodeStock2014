open System
open System.ServiceModel
open Microsoft.FSharp.Linq
open Microsoft.FSharp.Data.TypeProviders

//type TerraService = WsdlService<"http://msrmaps.com/TerraService2.asmx?WSDL">
type TerraService = WsdlService<"http://wsf.cdyne.com/weatherws/weather.asmx">

//[<EntryPoint>]
//let main argv = 
//    let client = TerraService.GetTerraServiceSoap()
//    let place = new TerraService.ServiceTypes.msrmaps.com.Place(City="Knoxville", State="TN", Country="United States")
//    let location = client.ConvertPlaceToLonLatPt(place);
//    printfn "Knoxville Latitude %f Longitude %f" location.Lat location.Lon
//    let result = Console.ReadKey()
//    0 

[<EntryPoint>]
let main argv = 
    let client = TerraService.GetWeatherSoap12()
    let forcast = client.GetCityForecastByZIP("37901")
    let location = forcast.ForecastResult |> Seq.iter(fun r -> printfn  "%A" r.Temperatures.DaytimeHigh)
    let result = Console.ReadKey()
    0 
