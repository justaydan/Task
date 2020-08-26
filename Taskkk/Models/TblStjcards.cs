using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblStjcards
    {
        public int StcjId { get; set; }
        public int? StcjGngId { get; set; }
        public string StcjGngCode { get; set; }
        public int? StcjEtsId { get; set; }
        public string StcjEtsCode { get; set; }
        public int? StcjStatus { get; set; }
    }
}
