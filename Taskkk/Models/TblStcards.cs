using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblStcards
    {
        public int StcId { get; set; }
        public string StcCode { get; set; }
        public string StcName { get; set; }
        public int? StcStatus { get; set; }
        public int? StcSttype { get; set; }
        public int? StcStgrecno { get; set; }
        public int? StcOther { get; set; }
        public string StcName1 { get; set; }
        public string StcName2 { get; set; }
        public string StcName3 { get; set; }
        public string StcName4 { get; set; }
        public string StcNote { get; set; }
        public int? StcGrtype { get; set; }
        public string StcGrname { get; set; }
    }
}
