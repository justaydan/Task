using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblPoints
    {
        public TblPoints()
        {
            TblFactFctBegpointNavigation = new HashSet<TblFact>();
            TblFactFctEndpointNavigation = new HashSet<TblFact>();
        }

        public string PntCode { get; set; }
        public int PntCountcode { get; set; }
        public string PntName { get; set; }
        public string PntName1 { get; set; }
        public string PntName2 { get; set; }
        public string PntName3 { get; set; }
        public string PntStatus { get; set; }
        public string PntType { get; set; }
        public string PntAtype { get; set; }
        public string PntGroup { get; set; }
        public int? PntRecno { get; set; }

        public virtual TblCountry PntCountcodeNavigation { get; set; }
        public virtual ICollection<TblFact> TblFactFctBegpointNavigation { get; set; }
        public virtual ICollection<TblFact> TblFactFctEndpointNavigation { get; set; }
    }
}
