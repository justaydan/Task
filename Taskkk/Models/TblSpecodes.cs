using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblSpecodes
    {
        public TblSpecodes()
        {
            TblFact = new HashSet<TblFact>();
            TblTransorders = new HashSet<TblTransorders>();
        }

        public int ScId { get; set; }
        public int? ScNtsid { get; set; }
        public int? ScRefid { get; set; }
        public string ScType { get; set; }
        public int? ScParent { get; set; }
        public string ScCode { get; set; }
        public string ScValue1 { get; set; }
        public string ScValue2 { get; set; }
        public string ScValue3 { get; set; }
        public string ScValue4 { get; set; }
        public int? ScDefault { get; set; }
        public int? ScOrder { get; set; }
        public int? ScStatus { get; set; }

        public virtual ICollection<TblFact> TblFact { get; set; }
        public virtual ICollection<TblTransorders> TblTransorders { get; set; }
    }
}
