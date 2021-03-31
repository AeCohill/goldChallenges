using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repo
{
    public class Claim
    {
        public string ClaimNum { get; set; }
        public string ClaimType { get; set; }

        public string Description { get; set; }
        public decimal ClaimPrice { get; set; }
        public string DateOfClaim { get; set; }
        public string ReportDate { get; set; }
        public bool IsTrue { get; set; }


        public Claim() { }
        public Claim(string claimNum, string claimType, string description, decimal claimPrice, string dateOfClaim, string reportDate, bool isTrue)
        {
            ClaimNum = claimNum;
            ClaimPrice = claimPrice;
            ClaimType = claimType;
            Description = description;
            DateOfClaim = dateOfClaim;
            ReportDate = reportDate;
            IsTrue = isTrue;
        }

    }
}
