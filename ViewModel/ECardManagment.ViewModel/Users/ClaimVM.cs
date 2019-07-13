using System.Collections.Generic;

namespace ECardManagment.ViewModel.Users
{
    public class ClaimVM
    {
        public string Name { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string NameClaimType { get; set; }
        public string RoleClaimType { get; set; }
        public object Label { get; set; }

        public List<ClaimDetail> ClaimDetail { get; set; }

        public ClaimVM()
        {
            ClaimDetail = new List<ClaimDetail>();
        }
    }

    public class ClaimDetail
    {
        public string Issuer { get; set; }
        public string OriginalIssuer { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string ValueType { get; set; }
    }

}
