using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tff.BugFreeCode.CS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Claim> allClaims = new List<Claim>();
            allClaims.Add(new Claim(1, 1, 1, DateTime.Now, 100.00));
            allClaims.Add(new Claim(2, 1, 2, DateTime.Now, 201.00));
            allClaims.Add(new Claim(3, 1, 3, DateTime.Now, 350.00));
            allClaims.Add(new Claim(4, 1, 4, DateTime.Now, 600.00));

            ClaimProcessor processor = new ClaimProcessor(allClaims);
            var goodClaims = processor.GetGoodClaims();

            Console.WriteLine(String.Format("{0} Claims in allClaims", allClaims.Count));
            Console.WriteLine(String.Format("{0} Claims in goodClaims", goodClaims.Count));

            Console.ReadKey();
        }
    }
}
