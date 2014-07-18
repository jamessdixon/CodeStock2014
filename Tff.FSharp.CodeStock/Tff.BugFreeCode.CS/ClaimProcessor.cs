using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tff.BugFreeCode.CS
{
    public class ClaimProcessor
    {
        List<Claim> _claims = null;

        public ClaimProcessor(List<Claim> claims)
        {
            _claims = claims;
        }

        public List<Claim> GetGoodClaims()
        {
            List<Claim> goodClaims = _claims;
            goodClaims.RemoveAll(claim => claim.IsASuspectClaim);
            return goodClaims;
        }
    }
}
