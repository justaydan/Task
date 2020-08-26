using System;
using System.Collections.Generic;

namespace Taskkk.Models
{
    public partial class TblStatus
    {
        public TblStatus()
        {
            TblFact = new HashSet<TblFact>();
        }

        public int StId { get; set; }
        public string StDefinition { get; set; }

        public virtual ICollection<TblFact> TblFact { get; set; }
    }
}
