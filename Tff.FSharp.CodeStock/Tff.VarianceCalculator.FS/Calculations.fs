namespace Tff.VarianceCalculator.FSff.BasicStats.FSharp
 
open System
open System.Collections.Generic
 
//http://www.mathsisfun.com/data/standard-deviation.html
type Calculations() =
    static member Variance (source:IEnumerable<double>) =
        let mean = Seq.average source
        let deltas = Seq.map(fun x -> pown(x-mean) 2) source
        Seq.average deltas
