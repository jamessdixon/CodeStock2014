using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tff.Ransom.CS
{
    public class DollarProvider
    {
        //static String GetSerialNumber()
        //{
        //    Random random = new Random();
        //    String serialNumber = String.Empty;
        //    for (int j = 0; j < 9; j++)
        //    {
        //        serialNumber += random.Next(0, 9).ToString();
        //    }
        //    return serialNumber;
        //}

        //public List<Dollar> GetDollars(Int32 numberOfDollars)
        //{
        //    List<Dollar> dollars = new List<Dollar>();
        //    Dollar currentDollar = null;
        //    Random random = new Random();
        //    for (int i = 0; i < numberOfDollars; i++)
        //    {
        //        currentDollar = new Dollar();
        //        currentDollar.Id = i;
        //        currentDollar.FederalReserveDistrict = random.Next(1, 13);
        //        currentDollar.SeriesDate = 2000 + random.Next(0, 10);
        //        dollars.Add(currentDollar);
        //    }
        //    Dictionary<Int32, String> serialNumbers = new Dictionary<Int32, String>();
        //    for (int i = 0; i < numberOfDollars; i++)
        //    {
        //        serialNumbers.Add(i, GetSerialNumber());
        //    }
        //    foreach (var dollar in dollars)
        //    {
        //        Int32 currentId = dollar.Id;
        //        foreach (var serialNumber in serialNumbers)
        //        {
        //            if (currentId == serialNumber.Key)
        //            {
        //                dollar.SerialNumber = serialNumber.Value;
        //                break;
        //            }
        //        }
        //    }
        //    return dollars;
        //}

        //Linq
        public List<Dollar> GetDollars(Int32 numberOfDollars)
        {
            Dollar[] dollars = new Dollar[numberOfDollars];
            dollars.Select((item, i) => CreateDollar(i)).ToArray<Dollar>();
            return dollars.ToList<Dollar>();
        }

        internal Dollar CreateDollar(Int32 dollarId)
        {
            Random random = new Random();
            var dollar = new Dollar();
            dollar.FederalReserveDistrict = random.Next(1, 13);
            dollar.SerialNumber = GetSerialNumber();
            dollar.SeriesDate = 2000 + random.Next(0, 10);
            dollar.Id = dollarId;

            return dollar;
        }

        internal string GetSerialNumber()
        {
            Random random = new Random();
            String serialNumber = String.Empty;
            for (int j = 0; j < 9; j++)
            {
                serialNumber += random.Next(0, 9).ToString();
            }
            return serialNumber;
        }

        //Pointers
        //public unsafe List<Dollar> GetDollars(Int32 numberOfDollars)
        //{
        //    Dollar[] dollars = new Dollar[numberOfDollars];
        //    Random random = new Random();
        //    fixed (byte* dollarBase = dollars)
        //    {
        //        byte* dollarPosiion = dollarBase;
        //        byte* dollarEnd = dollarBase + Dollar.Length;
        //    }
        //    while (dollarPosiion != dollarEnd)
        //    {
        //        newValue = *dollarPosition + serialNumberOffset;
        //        *dollarPosition = (byte)newValue;
        //        dollarPosiion += Dollar.Length;
        //    }
        //    return dollars.ToList<Dollar>();
        //}

        //GOTO
        //public List<Dollar> GetDollars(Int32 numberOfDollars)
        //{
        //    List<Dollar> dollars = new List<Dollar>();
        //    Dollar currentDollar = null;
        //    Random random = new Random();
        //    for (int i = 0; i < numberOfDollars; i++)
        //    {
        //        currentDollar = new Dollar();
        //        currentDollar.FederalReserveDistrict = random.Next(1, 13);
        //        currentDollar.Id = i;
        //        String serialNumber = String.Empty;
        //        for (int j = 0; j < 99; j++)
        //        {
        //            serialNumber += random.Next(0, 9).ToString();
        //            if (j == 9)
        //            {
        //                goto Outer;
        //            }
        //        }
        //    Outer:
        //        currentDollar.SerialNumber = serialNumber;
        //        currentDollar.SeriesDate = 2000 + random.Next(0, 10);
        //        dollars.Add(currentDollar);
        //    }
        //    return dollars;
        //}
    }
}
