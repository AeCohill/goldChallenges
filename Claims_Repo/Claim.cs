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
        public int V1 { get; }
        public string V2 { get; }
        public int V3 { get; }
        public string V4 { get; }
        public string V5 { get; }
        public bool V6 { get; }

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

        public Claim(int v1, string v2, int v3, string v4, string v5, bool v6)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
        }
    }
}
